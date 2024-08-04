using System;
namespace SanaCommerce.Application.DTOs
{
	public class ShoppingCartRequestDto
	{
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public IEnumerable<ShoppingCartItemDto> ShoppingCartItems { get; set; }
    }
}

