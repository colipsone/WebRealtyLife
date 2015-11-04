using System;
using System.Collections.Generic;
using WRL.Model.Interface.Entity.Common;
using WRL.Model.Interface.Security;

namespace WRL.Model.Entity.Apartment
{
    public class Region: AuditedEntity, ILookup
    {
        public string Name { get; set; }

        public Guid CityId { get; set; } 

        public City City { get; set; }

        public virtual ICollection<Street> Streets { get; set; }

        public virtual ICollection<SubwayStation> SubwayStations { get; set; }
    }
}
