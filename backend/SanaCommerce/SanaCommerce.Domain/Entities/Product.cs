using System;
using System.ComponentModel.DataAnnotations;

namespace SanaCommerce.Domain.Entities
{
	public class Product
	{
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

