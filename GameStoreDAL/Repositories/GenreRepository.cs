using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IGenreRepository
    {
        void Create(Genre model);
        void Update(Genre model);
        void Delete(int id);
        Genre GetById(int id);
        IEnumerable<Genre> GetAll();
    }

    public class GenreRepository : GenericRepository<Genre, int>, IGenreRepository
    {
        public override IEnumerable<Genre> GetAll()
        {
            return _table.Include(x => x.Games).ToList();
        }

        
    }
}
