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
        IEnumerable<Publisher> GetAll();
    }

    public class PublisherRepository : GenericRepository<Publisher, int>, IPublisherRepository
    {
        public override IEnumerable<Publisher> GetAll()
        {
            return _table.Include(x => x.Games).ToList();
        }

        
    }
}
