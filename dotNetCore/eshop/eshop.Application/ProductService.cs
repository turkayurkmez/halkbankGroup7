using eshop.Entities;

namespace eshop.Application
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product{ Id=1, Name="AAA", Description="Sample of text", DiscountRate=0.15, Price=250},
                new Product{ Id=2, Name="BBB", Description="Sample of text 2", DiscountRate=0.25, Price=1250},
                new Product{ Id=3, Name="CCC", Description="Sample of text 3", DiscountRate=0.15, Price=2250}

            };

            return products;
        }
    }
}
