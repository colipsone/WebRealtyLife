using System.Collections.Generic;
using WRL.Model.Entity.Apartment;

namespace WRL.Service.Interface
{
    public interface IApartmentService
    {
        IEnumerable<Apartment> GetAll();
    }
}
