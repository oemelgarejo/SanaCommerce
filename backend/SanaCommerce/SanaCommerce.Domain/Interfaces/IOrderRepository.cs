using System;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Domain.Interfaces
{
	public interface IOrderRepository
	{
        Task<Order> CreateOrder(Order order);
    }
}

