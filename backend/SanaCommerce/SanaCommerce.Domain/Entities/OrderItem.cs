using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaCommerce.Domain.Entities
{
	public class OrderItem
	{
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}

