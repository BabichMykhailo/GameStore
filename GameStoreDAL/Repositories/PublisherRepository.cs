using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IPublisherRepository
    {
        void Create(Publisher model);
        void Update(Publisher model);
        void Delete(int id);
        Publisher GetById(int id);
        IEnumerable<Publisher> GetAllPublishers();
    }

    public class PublisherRepository : GenericRepository<Publisher, int>, IPublisherRepository
    {
        public IEnumerable<Publisher> GetAllPublishers()
        {
            return GetAll().Include(x => x.Games).ToList();
        }

        public Publisher GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }
    }
}
