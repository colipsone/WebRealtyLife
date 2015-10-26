using System;
using System.Data.Entity.Infrastructure;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using WRL.Model.Entity.Security;
using WRL.Service.Interface;

namespace WRL.Service
{
    public class AuthorizationService: IAuthorizationService
    {
        private readonly UserManager<ApplicationUser> _usertManager;

        public AuthorizationService(UserManager<ApplicationUser> usertManager)
        {
            this._usertManager = usertManager;
        }

        #region Methods: Public

        public bool AuthorizeActivity(string activityName, ClaimsIdentity currentUser)
        {
            throw new UnauthorizedAccessException("User don't have access to see this information!");
        } 

        #endregion
    }
}
