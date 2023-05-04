using eshop.Data.Data;
using eshop.Entities;
using Microsoft.EntityFrameworkCore;

namespace eshop.Data.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EshopDbContext eshopDbContext;

        public EFProductRepository(EshopDbContext eshopDbContext)
        {
            this.eshopDbContext = eshopDbContext;
        }

        public async Task CreateNew(Product entity)
        {
            await eshopDbContext.Products.AddAsync(entity);
            await eshopDbContext.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var product = await eshopDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            eshopDbContext.Products.Remove(product);
            await eshopDbContext.SaveChangesAsync();

        }

        public async Task<Product?> Get(int id)
        {
            var product = await eshopDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IList<Product>> GetAll()
        {
            var products = await eshopDbContext.Products.ToListAsync();
            return products;

        }

        public async Task<IList<Product>> GetProductsByCategoryId(string? categoryId)
        {
            int catId = int.Parse(categoryId);
            var products = await eshopDbContext.Products.Where(p => p.CategoryId == catId).ToListAsync();
            return products;
        }

        public async Task<IList<Product>?> SearchProductsByName(string productName)
        {
            var products = await eshopDbContext.Products.Where(p => p.Name.Contains(productName)).ToListAsync();
            return products;
        }

        public async Task Update(Product entity)
        {
            eshopDbContext.Products.Update(entity);
            await eshopDbContext.SaveChangesAsync();
        }
    }
}
