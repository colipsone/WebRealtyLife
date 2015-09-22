using System.Collections.Generic;
using WRL.Model.InputModels.ApartmentService;
using WRL.Model.ViewModels;

namespace WRL.DataLayer.Interfaces.Services
{
    public interface IApartmentService
    {
        IEnumerable<ApartmentViewModel> GetAll(GetAllInputModel inputParam);
    }
}
