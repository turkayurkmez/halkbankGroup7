using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}