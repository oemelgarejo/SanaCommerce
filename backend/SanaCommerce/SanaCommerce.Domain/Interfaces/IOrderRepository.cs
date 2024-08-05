using System;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Domain.Interfaces
{
	public interface IOrderRepository
	{
        Task<Order> CreateOrder(Order order);
        Task<IEnumerable<Order>> GetAllOrdersAsync(int pageNumber, int pageSize);
        Task<int> GetTotalOrderCountAsync();
    }
}

