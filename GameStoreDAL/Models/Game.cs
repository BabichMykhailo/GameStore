using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Models
{
    public class Game : IEntity<int>
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }

        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Discount { get; set; }

        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Genre> Genres { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
