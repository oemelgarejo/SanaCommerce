using System;
using AutoMapper;
using MediatR;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Domain.Entities;
using SanaCommerce.Domain.Interfaces;

namespace SanaCommerce.Application.Commands
{
	public class CreateOrderCommand
	{
        public class Command : IRequest<OrderDto>
        {
            public ShoppingCartRequestDto ShoppingCartRequest { get; set; }
            public Command(ShoppingCartRequestDto  shoppingCartRequestDto)
            {
                ShoppingCartRequest = shoppingCartRequestDto;
            }
        }

        public class Handler : IRequestHandler<Command, OrderDto>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IMapper _mapper;
            private readonly IMediator _mediator;
            private readonly IProductRepository _productRepository;

            public Handler(IOrderRepository orderRepository,
                IProductRepository productRepository,
                IMapper mapper,
                IMediator mediator)
            {
                _orderRepository = orderRepository;
                _mapper = mapper;
                _mediator = mediator;
                _productRepository = productRepository;
            }

            public async Task<OrderDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var productIds = request.ShoppingCartRequest.ShoppingCartItems.Select(i => i.ProductId).ToList();
                var products = await _productRepository.GetProductsByIdsAsync(productIds);

                var productDictionary = products.ToDictionary(p => p.Id);

                foreach (var item in request.ShoppingCartRequest.ShoppingCartItems)
                {
                    if (productDictionary.TryGetValue(item.ProductId, out var product))
                    {
                        if (product.Stock < item.Quantity)
                        {
                            throw new InvalidOperationException($"Insufficient stock for product {product.Id}. Available: {product.Stock}, Requested: {item.Quantity}");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException($"Product with ID {item.ProductId} not found.");
                    }
                }

                var order = new Order
                {
                    Customer = new Customer { Email = request.ShoppingCartRequest.Email, FullName = request.ShoppingCartRequest.FullName },
                    OrderDate = DateTimeOffset.UtcNow,
                    OrderItems = request.ShoppingCartRequest.ShoppingCartItems.Select(i => new OrderItem
                    {
                        ProductId = i.ProductId,
                        Quantity = i.Quantity
                    }).ToList()
                };

                var orderSaved = await _orderRepository.CreateOrder(order);
                foreach (var item in request.ShoppingCartRequest.ShoppingCartItems)
                {
                    var product = productDictionary[item.ProductId];
                    product.Stock -= item.Quantity;
                    await _productRepository.UpdateProduct(product);
                }
                return _mapper.Map<OrderDto>(orderSaved);
            }
        }
    }
}

