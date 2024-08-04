using System;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Application.DTOs
{
	public class OrderDto
	{
        public Guid Id { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }
}

