using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        Task CreateNew(Product product);
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductsByCategory(string? categoryId);
        Task Update(Product product);
    }
}