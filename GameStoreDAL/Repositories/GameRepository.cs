using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Repositories
{
    public interface IGameRepository
    {
        void Create(Game model);
        void Update(Game model);
        void Delete(int id);
        Game GetById(int id);
        IEnumerable<Game> GetAll();
    }

    public class GameRepository : GenericRepository<Game, int>, IGameRepository
    {
        public override IEnumerable<Game> GetAll()
        {
            return _table
                .Include(x => x.Developer)
                .Include(x => x.Publisher)
                .Include(x => x.Genres)
                .Include(x => x.Genres)
                .ToList();
        }

        
    }
}
