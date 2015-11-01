using System;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using WRL.DataLayer.Interface.Repository;
using WRL.Model.Common.Security;
using WRL.Model.Entity.Security;
using WRL.Service.Interface;

namespace WRL.Service
{
    public class AuthService: IAuthService
    {
        private readonly IAuthRepository _authRepository;
        
        #region Ctors: Public

        public AuthService(IAuthRepository authRepository)
        {
            Contract.Requires(authRepository != null);

            _authRepository = authRepository;
        }

        #endregion

        #region Methods: Public

        public Task AuthorizeActivity(SecurityActivity activity, ClaimsIdentity currentUser)
        {
            Contract.Requires(currentUser != null);
            
            throw new UnauthorizedAccessException("User don't have access to see this information!");
        }

        public Task<IdentityResult> RegisterUser(string userName, string userPassword)
        {
            Contract.Requires(!string.IsNullOrEmpty(userName));
            Contract.Requires(!string.IsNullOrEmpty(userPassword));

            return _authRepository.RegisterUserAsync(userName, userPassword);
        }

        public Task<ApplicationUser> FindUser(string userName, string userPassword)
        {
            Contract.Requires(!string.IsNullOrEmpty(userName));
            Contract.Requires(!string.IsNullOrEmpty(userPassword));

            return _authRepository.FindUserAsync(userName, userPassword);
        }

        #endregion
    }
}
