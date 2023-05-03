using eshop.Entities;

namespace eshop.Application
{
    public interface ICategoryService
    {
        Task<IList<Category>> GetCategories();
    }
}