using System;
namespace SanaCommerce.Application.DTOs
{
	public class CustomerDto
	{
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}

