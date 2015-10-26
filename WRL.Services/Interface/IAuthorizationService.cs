using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.Entity.Security;

namespace WRL.Service.Interface
{
    public interface IAuthorizationService
    {
        bool AuthorizeActivity(string activityName, ClaimsIdentity identity);
    }
}
