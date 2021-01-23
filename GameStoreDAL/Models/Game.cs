using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Models
{
    public class Game
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }

        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Discount { get; set; }
    }
}
