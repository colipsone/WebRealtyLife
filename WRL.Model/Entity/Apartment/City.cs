using System.Collections.Generic;
using WRL.Model.Interface.Entity.Common;
using WRL.Model.Interface.Security;

namespace WRL.Model.Entity.Apartment
{
    public class City: AuditedEntity, ILookup
    {
        public string Name { get; set; }

        public virtual ICollection<Region> Regions { get; set; } 
    }
}
