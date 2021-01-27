using GameStoreDAL.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    public class DeveloperModel : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
