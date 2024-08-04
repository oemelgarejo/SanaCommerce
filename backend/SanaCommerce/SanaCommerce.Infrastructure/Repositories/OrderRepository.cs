using System;
using SanaCommerce.Domain.Entities;
using SanaCommerce.Domain.Interfaces;
using SanaCommerce.Infrastructure.Data;

namespace SanaCommerce.Infrastructure.Repositories
{
	public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

		public OrderRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<Order> CreateOrder(Order order)
        {
            await _context.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }
    }
}

