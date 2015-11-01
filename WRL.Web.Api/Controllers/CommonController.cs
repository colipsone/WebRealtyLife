using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using WRL.Model.Common.Security;
using WRL.Service.Interface;

namespace WRL.Web.Api.Controllers
{
    public class CommonController : ApiController
    {
        #region Members: Proteced

        protected readonly IAuthService AuthService;

        #endregion

        #region Ctors: Public

        public CommonController(IAuthService authService)
        {
            AuthService = authService;
        }
         
        #endregion

        protected void AuthorizeActivity(SecurityActivity activity)
        {
            AuthService.AuthorizeActivity(activity, new ClaimsIdentity());
        }
    }
}
