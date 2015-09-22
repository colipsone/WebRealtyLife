using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.DataLayer.Common;
using WRL.Model.DataLayer;
using WRL.Model.Entities.Apartment;
using IApartmentRepository = WRL.DataLayer.Interfaces.Repositories.IApartmentRepository;
using IWrlDbContext = WRL.DataLayer.Interfaces.IWrlDbContext;

namespace WRL.DataLayer.Repositories
{
    public class ApartmentRepository: Repository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(IWrlDbContext context) : base(context)
        {
        }
    }
}
