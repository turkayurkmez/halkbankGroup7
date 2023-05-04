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
                new Product{ Id=1, Name="AAA", Description="Sample of text", DiscountRate=0.15, Price=250, CategoryId=1},
                new Product{ Id=2, Name="BBB", Description="Sample of text 2", DiscountRate=0.25, Price=1250, CategoryId=2},
                new Product{ Id=3, Name="CCC", Description="Sample of text 3", DiscountRate=0.15, Price=2250, CategoryId = 3}

            };
        }
        public Task CreateNew(Product entity)
        {
            products.Add(entity);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }

        public Task<IList<Product>> GetAll()
        {
            return Task.FromResult(products);
        }

        public Task<IList<Product>> GetProductsByCategoryId(string? categoryId)
        {
            int value = int.Parse(categoryId);
            var result = (IList<Product>)products.Where(p => p.CategoryId == value).ToList();
            return Task.FromResult(result);

        }

        public Task<IList<Product>?> SearchProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            return Task.CompletedTask;
        }
    }
}
