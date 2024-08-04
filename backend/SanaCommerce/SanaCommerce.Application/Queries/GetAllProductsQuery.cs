using System;
using AutoMapper;
using MediatR;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Domain.Interfaces;

namespace SanaCommerce.Application.Queries
{
    public class GetAllProductsQuery
    {
        public class Query : IRequest<(IEnumerable<ProductDto> Products, int TotalPages)>
        {
            public int PageNumber { get; set; }
            public Query(int pageNumber)
            {
                PageNumber = pageNumber;
            }
        }

        public class Handler : IRequestHandler<Query, (IEnumerable<ProductDto> Products, int TotalPages)>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public Handler(IProductRepository productRepository,
                IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<(IEnumerable<ProductDto> Products, int TotalPages)> Handle(Query request, CancellationToken cancellationToken)
            {
                var pageSize = 10;
                var totalProductCount = await _productRepository.GetTotalProductCountAsync();
                var totalPages = (int)Math.Ceiling(totalProductCount / (double)pageSize);
                var products = await _productRepository.GetAllProductsAsync(request.PageNumber, pageSize);
                var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);
                return (productDtos, totalPages);
            }
        }
    }
}

