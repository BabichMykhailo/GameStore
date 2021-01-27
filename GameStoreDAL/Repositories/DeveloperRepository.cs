using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IDeveloperRepository
    {
        void Create(Developer model);
        void Update(Developer model);
        void Delete(int id);
        Developer GetById(int id);
        IEnumerable<Developer> GetAll();
    }

    public class DeveloperRepository : GenericRepository<Developer, int>, IDeveloperRepository
    {

        public override IEnumerable<Developer> GetAll()
        {
            return _table.Include(x => x.Games).ToList();
        }
    }

}
