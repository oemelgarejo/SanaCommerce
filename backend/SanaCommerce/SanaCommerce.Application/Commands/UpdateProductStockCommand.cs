using System;
using AutoMapper;
using MediatR;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Domain.Entities;
using SanaCommerce.Domain.Interfaces;

namespace SanaCommerce.Application.Commands
{
	public class UpdateProductStockCommand
	{
        public class Command : IRequest<ProductDto>
        {
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }

            public Command(Guid productId, int quantiy)
            {
                ProductId = productId;
                Quantity = quantiy;
            }
        }

        public class Handler : IRequestHandler<Command, ProductDto>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public Handler(IProductRepository productRepository,
                IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ProductDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetProductByIdAsync(request.ProductId);
                if (product == null) return null;

                product.Stock -= request.Quantity;
                var productUpdated = await _productRepository.UpdateProduct(product);
                return _mapper.Map<ProductDto>(productUpdated);
            }
        }
    }
}

