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
            CreateMap<GameModel, GameViewModel>();
            CreateMap<GameModel, GameViewModel>().ReverseMap();

        }
    }
}