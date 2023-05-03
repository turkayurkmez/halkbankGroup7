using eshop.Entities;

namespace eshop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IList<Product>> GetProductsByCategoryId(string? categoryId);
        Task<IList<Product>?> SearchProductsByName(string productName);

    }
}
