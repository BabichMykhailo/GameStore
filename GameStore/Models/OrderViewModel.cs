using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<GameViewModel> Games { get; set; }
    }
}