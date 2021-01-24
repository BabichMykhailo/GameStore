using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL.Models
{
    public class Publisher
    {
        public string Title { get; set; }
        public int Id { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
