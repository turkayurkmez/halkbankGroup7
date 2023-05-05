using eshop.Entities;

namespace eshop.Data.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task<IList<T>> GetAll();
        Task<T?> Get(int id);

        Task Update(T entity);
        Task Delete(int id);
        Task CreateNew(T entity);

        Task<bool> IsExists(int id);


    }
}
