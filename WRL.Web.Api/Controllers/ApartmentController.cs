using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using WRL.Service.Interface;
using WRL.Web.Api.ViewModels;

namespace WRL.Web.Api.Controllers
{
    [RoutePrefix("api/apartment")]
    public class ApartmentController : CommonController
    {
        private readonly IApartmentService _apartmentService;

        #region Ctors: Public

        public ApartmentController(IAuthService authService, IApartmentService apartmentService) : base(authService)
        {
            Contract.Requires(apartmentService != null);

            _apartmentService = apartmentService;
        }

        #endregion

        #region Methods: Public

        [HttpGet]
        [Route("getAll")]
        [Authorize]
        public async Task<IEnumerable<ApartmentViewModel>> GetAll()
        {
            return await _apartmentService.GetAll().AsQueryable().ProjectToListAsync<ApartmentViewModel>();
        }
         
        #endregion
    }


}
