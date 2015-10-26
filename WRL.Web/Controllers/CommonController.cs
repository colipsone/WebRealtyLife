using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WRL.DataLayer.Interface;
using WRL.Model.Entity.Security;
using WRL.Service.Interface;
using WRL.Web.Managers;

namespace WRL.Web.Controllers
{
    public class CommonController : ApiController
    {
        #region Fields: Private

        private readonly IWrlDbContext _context;
        private readonly IAuthorizationService _authorizationService;
        private readonly ApplicationUserManager _userManager;
        private ApplicationUser _currentUser;

        #endregion

        #region Ctors

        public CommonController(IWrlDbContext context,
            IAuthorizationService authorizationService,
            ApplicationUserManager userManager)
        {
            _context = context;
            _authorizationService = authorizationService;
            _userManager = userManager;
        }
         
        #endregion

        protected void AuthorizeByActivity()
        {
            
        }
    }
}
