using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using WRL.DataLayer.Repository;
using WRL.Service.Interface;
using WRL.Web.Api.ViewModels;

namespace WRL.Web.Api.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : CommonController
    {
        #region Ctors: Public

        public AccountController(IAuthService authService) : base(authService)
        {
        }
         
        #endregion

        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await AuthService.RegisterUser(userViewModel.UserName, userViewModel.Password);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        #region Methods: Private

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        } 

        #endregion
    }
}
