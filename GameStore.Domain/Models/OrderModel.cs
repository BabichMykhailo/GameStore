using GameStoreDAL.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    public class OrderModel 
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<GameModel> Games { get; set; }
    }
}
