using System;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Domain.Interfaces
{
	public interface IProductRepository
	{
        Task<IEnumerable<Product>> GetAllProductsAsync(int pageNumber, int pageSize);
        Task<Product?> GetProductByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetProductsByIdsAsync(IEnumerable<Guid> productIds);
        Task<Product> AddProduct(Product product);
        Task<Product?> UpdateProduct(Product product);
        Task<int> GetTotalProductCountAsync();
    }
}

