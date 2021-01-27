using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }

        public ICollection <Game> Games { get; set; }

    }
}
