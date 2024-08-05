using System;
using SanaCommerce.Application.DTOs;

namespace SanaCommerce.API.DTOs
{
	public class ProductResponse
	{
            public IEnumerable<ProductDto> Products { get; set; }
            public int TotalPages { get; set; }
    }
}

