using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using Microsoft.Owin;
using Microsoft.Practices.Unity;
using WRL.Model.Entity.Security;
using WRL.Service;
using WRL.Service.Interface;
using WRL.Web.Managers;

namespace WRL.Web.Attributes
{
    public class AuthorizeByActivityAttribute: AuthorizeAttribute
    {
        private readonly string _activityName;
        private readonly IAuthorizationService _authorizationService;
        private readonly ApplicationUserManager _userManager;

        public AuthorizeByActivityAttribute(string activityName)
        {
            _activityName = activityName;
            _authorizationService =
                UnityConfig.Container.Resolve(typeof(IAuthorizationService)) as
                    IAuthorizationService;
            _userManager = UnityConfig.Container.Resolve(typeof(ApplicationUserManager)) as
                    ApplicationUserManager;
        }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            /*ClaimsIdentity currentIdentity = actionContext.ControllerContext.RequestContext.Principal.Identity as ClaimsIdentity;
            OwinContext ctx = actionContext.Request.Properties["MS_OwinContext"] as OwinContext;
            var user = ctx.Request.User;*/
            var users = _userManager.Users.FirstOrDefault();
            /*if (currentIdentity == null)
            {
                return false;
            }*/
            return true;
            //return _authorizationService.AuthorizeActivity(_activityName, currentIdentity);
        }
    }
}