using WRL.DataLayer.Interface.Repository;
using WRL.DataLayer.Common;
using WRL.Model.Entity.Apartment;
using WRL.DataLayer.Interface;

namespace WRL.DataLayer.Repository
{
    public class ApartmentRepository: Repository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(IWrlDbContext context) : base(context)
        {
        }
    }
}
