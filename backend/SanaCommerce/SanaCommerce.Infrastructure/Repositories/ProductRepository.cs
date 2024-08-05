using System;
using Microsoft.EntityFrameworkCore;
using SanaCommerce.Domain.Entities;
using SanaCommerce.Domain.Interfaces;
using SanaCommerce.Infrastructure.Data;

namespace SanaCommerce.Infrastructure.Repositories
{
	public class ProductRepository : IProductRepository
    { 
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<Product> AddProduct(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(int pageNumber, int pageSize)
        {
            return await _context.Products.Skip((pageNumber - 1) * pageSize).Take(pageSize).OrderByDescending(x=> x.CreatedAt).ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
            return await _context.Products
                .Include(p => p.ProductCategories)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsByIdsAsync(IEnumerable<Guid> productIds)
        {
            return await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();
        }

        public Task<int> GetTotalProductCountAsync()
        {
            return _context.Products.CountAsync();
        }

        public async Task<Product?> UpdateProduct(Product product)
        {
            try
            {
                var existingProduct = await _context.Products.FindAsync(product.Id);
                if (existingProduct == null)
                {
                    return null;
                }

                _context.Entry(existingProduct).CurrentValues.SetValues(product);

                await _context.SaveChangesAsync();
                return existingProduct;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating the product: {ex.Message}");
            }
            return null;
        }
    }
}

