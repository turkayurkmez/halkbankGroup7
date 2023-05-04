using eshop.Data.Repositories;
using eshop.Entities;

namespace eshop.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task CreateNew(Product product)
        {
            await productRepository.CreateNew(product);
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await productRepository.Get(id);
        }

        //Aşağıdaki senkron fonksiyonu GetProductsAsync ile asenkron yaptık:
        //public IEnumerable<Product> GetProducts()
        //{
        //    //var products = new List<Product>
        //    //{
        //    //    new Product{ Id=1, Name="AAA", Description="Sample of text", DiscountRate=0.15, Price=250},
        //    //    new Product{ Id=2, Name="BBB", Description="Sample of text 2", DiscountRate=0.25, Price=1250},
        //    //    new Product{ Id=3, Name="CCC", Description="Sample of text 3", DiscountRate=0.15, Price=2250}

        //    //};

        //    //return products;

        //}

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await productRepository.GetAll();
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string? categoryId)
        {
            IList<Product> products = await productRepository.GetProductsByCategoryId(categoryId);
            return products;
        }

        public async Task Update(Product product)
        {
            await productRepository.Update(product);
        }
    }
}
