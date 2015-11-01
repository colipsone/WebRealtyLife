using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Unity.WebApi;
using WRL.Web.Api;

[assembly: OwinStartup(typeof(Startup))]

namespace WRL.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration
            {
                DependencyResolver = new UnityDependencyResolver(UnityConfig.Container)
            };
            AutoMapperConfig.MapEntities();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
