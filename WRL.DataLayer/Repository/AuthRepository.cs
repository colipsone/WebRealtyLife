using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using WRL.DataLayer.Interface.Repository;
using WRL.Model.Entity.Security;

namespace WRL.DataLayer.Repository
{
    public class AuthRepository: IAuthRepository, IDisposable
    {

        #region Members: Private

        private readonly UserManager<ApplicationUser> _userManager; 
        
        #endregion

        #region Ctors: Public

        public AuthRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
         
        #endregion

        #region Methods: Public

        public async Task<IdentityResult> RegisterUserAsync(string userName, string userPassword)
        {
            ApplicationUser identityUser = new ApplicationUser
            {
                UserName = userName
            };

            var result = await _userManager.CreateAsync(identityUser, userPassword);

            return result;
        }

        public async Task<ApplicationUser> FindUserAsync(string userName, string userPassword)
        {
            var identityUser = await _userManager.FindAsync(userName, userPassword);

            return identityUser;
        } 

        #endregion

        public void Dispose()
        {
            _userManager.Dispose();
        }
    }
}
