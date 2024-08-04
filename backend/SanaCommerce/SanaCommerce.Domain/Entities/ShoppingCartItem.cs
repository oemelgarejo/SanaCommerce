using System;
namespace SanaCommerce.Domain.Entities
{
	public class ShoppingCartItem
	{
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

