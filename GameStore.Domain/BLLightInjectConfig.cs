using GameStoreDAL;
using GameStoreDAL.Repositories;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain
{
    public class BLLightInjectConfig
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register<GameStoreContext>(new PerScopeLifetime());
            container.Register<IGameRepository, GameRepository>();
            //container.Register<ICategoryRepository, CategoryRepository>();

            return container;
        }
    }
}
