﻿using GameStoreDAL.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Models
{
    public class OrderModel : IEntity
    {
        public int Id { get; set; }
        public ICollection<GameModel> Games { get; set; }
    }
}
