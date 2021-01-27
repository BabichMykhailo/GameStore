using GameStoreDAL.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    public class DeveloperModel : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<GameModel> Games { get; set; }
    }
}
