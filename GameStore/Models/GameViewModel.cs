using GameStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class GameViewModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }

        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Discount { get; set; }

        public int DeveloperId { get; set; }
        public DeveloperViewModel Developer { get; set; }

        public int PublisherId { get; set; }
        public PublisherViewModel Publisher { get; set; }

        public ICollection<GenreViewModel> Genres { get; set; }
        public ICollection<OrderViewModel> Orders { get; set; }
    }
}