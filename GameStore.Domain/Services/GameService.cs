using AutoMapper;
using GameStore.Domain.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Services
{
    public interface IGameService
    {
        IEnumerable<GameModel> GetAll();
    }

    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameService(IGameRepository gameRepository)
        {
        var mapperConfig = new MapperConfiguration(cfg =>{cfg.AddProfile<BLAutoMapperProfile>();});
        _mapper = new Mapper(mapperConfig);
        _gameRepository = gameRepository;
        }

    public IEnumerable<GameModel> GetAll()
    {
        var games = _gameRepository.GetAll();
        return _mapper.Map<IEnumerable<GameModel>>(games);
    }
}
}
