using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.DataLayer;
using WRL.Model.Entities.Apartment;
using WRL.Model.InputModels.ApartmentService;
using WRL.Model.Services;
using WRL.Model.ViewModels;

namespace WRL.Services
{
    public class ApartmentService: IApartmentService
    {
        #region Fields: Private

        private readonly IApartmentRepository _apartmentRepository;

        #endregion

        #region Ctors: Public

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        #endregion

        #region Methods: Public

        public IEnumerable<ApartmentViewModel> GetAll(GetAllInputModel inputParam)
        {
            return _apartmentRepository.GetAll().Select(ap => ap.ToViewModel());
        }

        #endregion
    }
}
