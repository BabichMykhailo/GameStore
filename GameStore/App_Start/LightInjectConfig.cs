using GameStore.Domain;
using GameStore.Domain.Services;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace GameStore.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            //var config = new MapperConfiguration(cfg => cfg.AddProfiles(
            //      new List<Profile>() { new WebAutomapperProfile(), new BLAutomapperProfile() }));

            /*            container.Register(c => config.CreateMapper())*/
            ;

            container = BLLightInjectConfig.Configuration(container);

            container.Register<IGameService, GameService>();
            //container.Register<ICategoryService, CategoryService>();
            //container.Register<IEmailService, EmailService>();
            //container.Register<IArticleApiService, ArticleApiService>();
            //var resolver = new LightInjectWebApiDependencyResolver(container);             
            //DependencyResolver.SetResolver(new LightInjectMvcDependencyResolver(container));
            container.EnableMvc();
        }
    }
}