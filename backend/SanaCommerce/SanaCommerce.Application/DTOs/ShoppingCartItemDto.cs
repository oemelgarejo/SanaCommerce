using System;
namespace SanaCommerce.Application.DTOs
{
	public class ShoppingCartItemDto
	{
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

