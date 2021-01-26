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
        IEnumerable<Game> GetAllGames();
    }

    public class GameRepository : GenericRepository<Game, int>, IGameRepository
    {
        public IEnumerable<Game> GetAllGames()
        {
            return GetAll()
                .Include(x => x.Developer)
                .Include(x => x.Publisher)
                .Include(x => x.Genres)
                .Include(x => x.Genres)
                .ToList();
        }

        public Game GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }
    }
}
