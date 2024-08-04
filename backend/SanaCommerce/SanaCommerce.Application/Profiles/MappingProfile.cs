using System;
using AutoMapper;
using SanaCommerce.Application.DTOs;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Application.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
            CreateMap<Product, ProductDto>().ReverseMap();
			CreateMap<Order, OrderDto>().ReverseMap();
			CreateMap<Customer, CustomerDto>().ReverseMap();
			CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        }
	}
}

