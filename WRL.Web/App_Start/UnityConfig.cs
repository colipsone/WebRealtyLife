using System;
using System.Data.Entity;
using System.Web;
using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Unity.WebApi;
using WRL.DataLayer;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Repository;
using WRL.DataLayer.Interface.Repository;
using WRL.Model.Entity.Security;
using WRL.Service;
using WRL.Service.Interface;
using WRL.Web.Managers;

namespace WRL.Web
{
    public static class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> UnityContainerLazy = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterComponents(container);
            return container;

        });

        public static IUnityContainer Container
        {
            get
            {
                return UnityContainerLazy.Value;
            }
        }

        private static void RegisterComponents(IUnityContainer container)
        {
            #region Repositories Registration

            container.RegisterType<IApartmentRepository, ApartmentRepository>(new HierarchicalLifetimeManager());

            #endregion

            #region DbContext Registration

            container.RegisterType<IWrlDbContext, WrlDbContext>(new HierarchicalLifetimeManager());

            #endregion

            #region Services Registration

            container.RegisterType<IApartmentService, ApartmentService>(new HierarchicalLifetimeManager());

            container.RegisterType<IAuthorizationService, AuthorizationService>(new HierarchicalLifetimeManager());

            #endregion

            #region Concrete Types Registration

            container.RegisterType<UserManager<ApplicationUser>, ApplicationUserManager>();

            container.RegisterType<ApplicationSignInManager>();

            #endregion

            container.RegisterType<IAuthenticationManager>(
                new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(
                new InjectionConstructor(typeof (WrlDbContext)));
        }
    }
}