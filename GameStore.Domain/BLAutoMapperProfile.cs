using AutoMapper;
using GameStore.Domain.Models;
using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain
{
    public class BLAutoMapperProfile : Profile
    {
        public BLAutoMapperProfile()
        {
            CreateMap<Developer, DeveloperModel>();
            CreateMap<Developer, DeveloperModel>().ReverseMap();

            CreateMap<Game, GameModel>();
            CreateMap<Game, GameModel>().ReverseMap();

            CreateMap<Genre, GenreModel>();
            CreateMap<Genre, GenreModel>().ReverseMap();

            CreateMap<Order, OrderModel>();
            CreateMap<Order, OrderModel>().ReverseMap();

            CreateMap<Publisher, PublisherModel>();
            CreateMap<Publisher, PublisherModel>().ReverseMap();
        }
    }
}
