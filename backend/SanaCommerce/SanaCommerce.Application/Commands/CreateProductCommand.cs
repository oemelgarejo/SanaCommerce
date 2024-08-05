using System;
using AutoMapper;
using MediatR;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Domain.Entities;
using SanaCommerce.Domain.Interfaces;

namespace SanaCommerce.Application.Commands
{
	public class CreateProductCommand
	{
        public class Command : IRequest<ProductDto>
        {
            public ProductDto ProductDto { get; set; }
            public Command(ProductDto productDto)
            {
                ProductDto = productDto;
            }
        }

        public class Handler : IRequestHandler<Command, ProductDto>
        {
            private readonly IMapper _mapper;
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository,
                IMapper mapper,
                IMediator mediator)
            {
                _mapper = mapper;
                _productRepository = productRepository;
            }

            public async Task<ProductDto> Handle(Command request, CancellationToken cancellationToken)
            {
                Product productEntity = _mapper.Map<Product>(request.ProductDto);
                var productSaved = await _productRepository.AddProduct(productEntity);
                if (productSaved == null) throw new Exception("Product can't be create");
                return _mapper.Map<ProductDto>(productSaved);
            }
        }
    }
}

