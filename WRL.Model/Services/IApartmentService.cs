using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.Entities.Apartment;
using WRL.Model.InputModels;
using WRL.Model.InputModels.ApartmentService;
using WRL.Model.ViewModels;

namespace WRL.Model.Services
{
    public interface IApartmentService
    {
        IEnumerable<ApartmentViewModel> GetAll(GetAllInputModel inputParam);
    }
}
