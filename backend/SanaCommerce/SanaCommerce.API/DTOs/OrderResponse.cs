using System;
using SanaCommerce.Application.DTOs;

namespace SanaCommerce.API.DTOs
{
	public class OrderResponse
	{
        public IEnumerable<OrderDto> Orders { get; set; }
        public int TotalPages { get; set; }
    }
}

