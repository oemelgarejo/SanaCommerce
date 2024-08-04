using System;
namespace SanaCommerce.Domain.Entities
{
	public class Customer
	{
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

