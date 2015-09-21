using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WRL.DataLayer;
using WRL.DataLayer.Common;
using WRL.DataLayer.Repositories;
using WRL.Model.DataLayer;
using WRL.Model.Entities.Apartment;

namespace WRL.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IApartmentRepository, ApartmentRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}