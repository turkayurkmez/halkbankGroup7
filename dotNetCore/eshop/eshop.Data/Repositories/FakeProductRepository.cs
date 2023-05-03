using eshop.Entities;

namespace eshop.Data.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private IList<Product> products;
        public FakeProductRepository()
        {
            products = new List<Product>
            {
                new Product{ Id=1, Name="AAA", Description="Sample of text", DiscountRate=0.15, Price=250},
                new Product{ Id=2, Name="BBB", Description="Sample of text 2", DiscountRate=0.25, Price=1250},
                new Product{ Id=3, Name="CCC", Description="Sample of text 3", DiscountRate=0.15, Price=2250}

            };
        }
        public Task CreateNew(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAll()
        {
            return Task.FromResult(products);
        }

        public Task<IList<Product>?> SearchProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
