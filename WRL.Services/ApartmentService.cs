using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.Entity;
using WRL.Model.Entity.Apartment;
using WRL.DataLayer.Interface.Repository;
using WRL.Service.Interface;

namespace WRL.Service
{
    public class ApartmentService: IApartmentService
    {
        #region Fields: Private

        private readonly IApartmentRepository _apartmentRepository;

        #endregion

        #region Ctors: Public

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            Contract.Requires(apartmentRepository != null);

            _apartmentRepository = apartmentRepository;
        }

        #endregion

        #region Methods: Public

        public IEnumerable<Apartment> GetAll()
        {
            return _apartmentRepository.GetAll();
        }

        #endregion
    }
}
