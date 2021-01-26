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
        IEnumerable<Developer> GetAllDevelopers();
    }

    public class DeveloperRepository : GenericRepository<Developer, int>, IDeveloperRepository
    {
        public IEnumerable<Developer> GetAllDevelopers()
        {
            return GetAll().Include(x => x.Games).ToList();
        }

        public Developer GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }
    }

}
