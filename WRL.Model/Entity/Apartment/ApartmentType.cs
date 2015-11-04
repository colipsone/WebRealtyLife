using System.Collections.Generic;
using WRL.Model.Interface.Entity.Common;
using WRL.Model.Interface.Security;

namespace WRL.Model.Entity.Apartment
{
    public class ApartmentType: AuditedEntity, ILookup
    {
        public string Name { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; } 
    }
}
