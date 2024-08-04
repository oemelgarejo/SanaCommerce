using System;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Application.DTOs
{
    public class OrderItemDto
    {
        public Guid OrderId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}
