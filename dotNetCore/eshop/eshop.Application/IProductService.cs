using eshop.Application.DataTransferObjects.Requests;
using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        Task CreateNew(Product product);
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductsByCategory(string? categoryId);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
        Task<int> CreateNew(CreateNewProductRequest request);
        Task Update(Product product);

        //Not: Yeni bir metod yazdık. Çünkü, MVC uygulaması DTO'ları kullanmıyor. Orada bu değişiklikleri yapmamak için yeni metot yazıldı
        Task<int> Update(UpdateProductRequest request);
        Task<bool> IsProductExists(int id);

        Task DeleteAsync(int id);
    }
}