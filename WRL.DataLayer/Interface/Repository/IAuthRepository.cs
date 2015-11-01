using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using WRL.Model.Entity.Security;

namespace WRL.DataLayer.Interface.Repository
{
    public interface IAuthRepository
    {
        Task<IdentityResult> RegisterUserAsync(string userName, string userPassword);

        Task<ApplicationUser> FindUserAsync(string userName, string userPassword);
    }
}
