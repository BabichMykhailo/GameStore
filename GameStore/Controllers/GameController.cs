using AutoMapper;
using GameStore.App_Start;
using GameStore.Domain.Services;
using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;


        public GameController(IGameService gameService)
        {
            var mapperConfig = new MapperConfiguration(cfg => { cfg.AddProfile<WebAutoMapperProfile>();});
            _mapper = new Mapper(mapperConfig);
            _gameService = gameService;
        }
        // GET: Game
        public ActionResult Index()
        {
            var games = _gameService.GetAll();
            var model = _mapper.Map<IEnumerable<GameViewModel>>(games);
            return View(model);
        }

        
    }
}