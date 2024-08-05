using System;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Application.DTOs
{
	public class ProductDto
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public IEnumerable<ProductCategory>? ProductCategories { get; set; }
    }
}

