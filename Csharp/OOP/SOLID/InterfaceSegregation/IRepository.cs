using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Product
    {

    }
    public class Campaign
    {

    }
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        IList<T> GetAll();

      
    }

    public interface IProductRepository : IRepository<Product>
    {
        public IList<Product> SearchProductsByName(string name);
    }

    public class ProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public class CampaignRepository : IRepository<Campaign>, IComparable<Campaign>
    {
      

        public void Create(Campaign entity)
        {
            throw new NotImplementedException();
        }

        public IList<Campaign> GetAll()
        {
            throw new NotImplementedException();
        }

       

        public void Update(Campaign entity)
        {
            throw new NotImplementedException();
        }
    }
}
