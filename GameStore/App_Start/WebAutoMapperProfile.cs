using AutoMapper;
using GameStore.Domain.Models;
using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.App_Start
{
    public class WebAutoMapperProfile : Profile
    {
        public WebAutoMapperProfile()
        {
            CreateMap<DeveloperModel, DeveloperViewModel>();
            CreateMap<DeveloperModel, DeveloperViewModel>().ReverseMap();

            CreateMap<GameModel, GameViewModel>();
            CreateMap<GameModel, GameViewModel>().ReverseMap();

            CreateMap<GenreModel, GenreViewModel>();
            CreateMap<GenreModel, GenreViewModel>().ReverseMap();

            CreateMap<OrderModel, OrderViewModel>();
            CreateMap<OrderModel, OrderViewModel>().ReverseMap();

            CreateMap<PublisherModel, PublisherViewModel>();
            CreateMap<PublisherModel, PublisherViewModel>().ReverseMap();
        }
    }
}