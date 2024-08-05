using System;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Order>> GetAllOrdersAsync(int pageNumber, int pageSize)
        {
            return await _context.Orders                
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Include(o => o.Customer)
                .Include(o => o.OrderItems)
                .ThenInclude(p => p.Product)
                .OrderByDescending(x => x.OrderDate)
                .ToListAsync();
        }

        public Task<int> GetTotalOrderCountAsync()
        {
            return _context.Orders.CountAsync();
        }
    }
}

