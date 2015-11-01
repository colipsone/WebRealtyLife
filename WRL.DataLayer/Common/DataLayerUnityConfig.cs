using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Interface.Repository;
using WRL.DataLayer.Repository;
using WRL.Model.Entity.Security;

namespace WRL.DataLayer.Common
{
    public static class DataLayerUnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            #region Repositories Registration

            container.RegisterType<IApartmentRepository, ApartmentRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IAuthRepository, AuthRepository>(new HierarchicalLifetimeManager());

            #endregion

            #region DbContext Registration

            container.RegisterType<IWrlDbContext, WrlDbContext>(new HierarchicalLifetimeManager());

            #endregion

            container.RegisterType<UserManager<ApplicationUser>, UserManager<ApplicationUser>>();

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(
                new InjectionConstructor(typeof(WrlDbContext)));
        }
    }
}
