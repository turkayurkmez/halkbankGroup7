using eshop.Data.Data;
using eshop.Entities;
using Microsoft.EntityFrameworkCore;

namespace eshop.Data.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly EshopDbContext eshopDbContext;

        public EFCategoryRepository(EshopDbContext eshopDbContext)
        {
            this.eshopDbContext = eshopDbContext;
        }

        public Task CreateNew(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Category>> GetAll()
        {
            return await eshopDbContext.Categories.ToListAsync();
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
