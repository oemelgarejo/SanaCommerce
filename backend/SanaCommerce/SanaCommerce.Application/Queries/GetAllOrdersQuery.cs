using System;
using AutoMapper;
using MediatR;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Domain.Interfaces;

namespace SanaCommerce.Application.Queries
{
    public class GetAllOrdersQuery
    {
        public class Query : IRequest<(IEnumerable<OrderDto> Orders, int TotalPages)>
        {
            public int PageNumber { get; set; }
            public Query(int pageNumber)
            {
                PageNumber = pageNumber;
            }
        }

        public class Handler : IRequestHandler<Query, (IEnumerable<OrderDto> Orders, int TotalPages)>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IMapper _mapper;

            public Handler(IOrderRepository orderRepository,
                IMapper mapper)
            {
                _orderRepository = orderRepository;
                _mapper = mapper;
            }

            public async Task<(IEnumerable<OrderDto> Orders, int TotalPages)> Handle(Query request, CancellationToken cancellationToken)
            {
                var pageSize = 10;
                var totalProductCount = await _orderRepository.GetTotalOrderCountAsync();
                var totalPages = (int)Math.Ceiling(totalProductCount / (double)pageSize);
                var orders = await _orderRepository.GetAllOrdersAsync(request.PageNumber, pageSize);
                var orderDtos = _mapper.Map<IEnumerable<OrderDto>>(orders);
                return (orderDtos, totalPages);
            }
        }
    }
}

