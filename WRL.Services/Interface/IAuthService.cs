using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using WRL.Model.Common.Security;
using WRL.Model.Entity.Security;

namespace WRL.Service.Interface
{
    public interface IAuthService
    {
        Task AuthorizeActivity(SecurityActivity activity, ClaimsIdentity identity);

        Task<IdentityResult> RegisterUser(string userName, string userPassword);

        Task<ApplicationUser> FindUser(string userName, string userPassword);
    }
}
