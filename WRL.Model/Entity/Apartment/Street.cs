using System;
using System.Collections.Generic;
using WRL.Model.Interface.Entity.Common;
using WRL.Model.Interface.Security;

namespace WRL.Model.Entity.Apartment
{
    public class Street: AuditedEntity, ILookup
    {
        public string Name { get; set; }

        public Guid RegionId { get; set; }

        public Region Region { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; } 
    }
}
