using eshop.Entities;

namespace eshop.Application
{
    public class AlterProductService : IProductService
    {
        //ProductService: Product ile ilgili tüm işlemlerden sorumlu nesne
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product{ Id=4, Name="DDD", Description="Sample of text", DiscountRate=0.15, Price=250},
                new Product{ Id=5, Name="EEE", Description="Sample of text 2", DiscountRate=0.25, Price=1250},
                new Product{ Id=6, Name="FCC", Description="Sample of text 3", DiscountRate=0.15, Price=2250}

            };

            return products;
        }
    }
}
