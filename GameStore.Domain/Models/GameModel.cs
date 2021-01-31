using GameStoreDAL.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    public class GameModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Discount { get; set; }
        public int DeveloperId { get; set; }
        public DeveloperModel Developer { get; set; }
        public int PublisherId { get; set; }
        public PublisherModel Publisher { get; set; }
        public ICollection<GenreModel> Genres { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
    
}
