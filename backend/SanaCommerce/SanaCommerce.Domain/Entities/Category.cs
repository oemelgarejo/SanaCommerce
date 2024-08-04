using System;
namespace SanaCommerce.Domain.Entities
{
	public class Category
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}

