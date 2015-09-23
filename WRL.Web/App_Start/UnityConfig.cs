using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WRL.DataLayer;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Repository;
using WRL.DataLayer.Interface.Repository;
using WRL.Service;
using WRL.Service.Interface;

namespace WRL.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            #region Repository Registration

            container.RegisterType<IApartmentRepository, ApartmentRepository>(new HierarchicalLifetimeManager());

            #endregion

            #region DbContext Registration

            container.RegisterType<IWrlDbContext, WrlDbContext>(new HierarchicalLifetimeManager());

            #endregion

            #region Service Registration

            container.RegisterType<IApartmentService, ApartmentService>(new HierarchicalLifetimeManager()); 

            #endregion

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}