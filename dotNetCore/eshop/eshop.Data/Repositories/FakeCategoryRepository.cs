using eshop.Entities;

namespace eshop.Data.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private IList<Category> categories;
        public FakeCategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category() { Id = 1, Name="Bilgisayar"},
                new Category() { Id = 2, Name="Kırtasiye"},
                new Category() { Id = 3, Name="Kitap"}
            };
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

        public Task<IList<Category>> GetAll()
        {
            return Task.FromResult(categories);
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
