using eshop.Data.Repositories;
using eshop.Entities;

namespace eshop.Application
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<IList<Category>> GetCategories()
        {
            return await categoryRepository.GetAll();
        }
    }
}
