using System;
namespace SanaCommerce.Domain.Entities
{
	public class Order
	{
        public Guid Id { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

