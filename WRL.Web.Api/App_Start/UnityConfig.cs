using System;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WRL.DataLayer.Common;
using WRL.Service;
using WRL.Service.Interface;

namespace WRL.Web.Api
{
    public static class UnityConfig
    {
        #region Members: Private

        private static Lazy<UnityContainer> _container = new Lazy<UnityContainer>(() => RegisterComponents());

        #endregion

        #region Properties: Public

        public static UnityContainer Container
        {
            get { return _container.Value; }
        }

        #endregion

        #region Methods: Private

        private static UnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            DataLayerUnityConfig.RegisterComponents(container);

            container.RegisterType<IAuthService, AuthService>(new HierarchicalLifetimeManager());
            container.RegisterType<IApartmentService, ApartmentService>(new HierarchicalLifetimeManager());

            return container;
        }
         
        #endregion
    }
}