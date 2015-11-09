using System;
using System.Collections.Generic;
using WRL.Model.Interface.Security;

namespace WRL.Model.Entity.Apartment
{
    public class Apartment: AuditedEntity
    {
        #region Simple Type Properties

        public int FloorNumber { get; set; }

        public int FloorsAmount { get; set; }

        public int Square { get; set; }

        public string HouseNumber { get; set; }

        public int RoomsNumber { get; set; }

        public string Price { get; set; }

        public string Note { get; set; }

        public string Number { get; set; }

        #endregion

        #region Lookup Properties

        public Guid StreetId { get; set; }

        public Street Street { get; set; }

        public Guid? ApartmentTypeId { get; set; }

        public virtual ApartmentType ApartmentType { get; set; }

        public Guid? SubwayStationId { get; set; }

        public virtual SubwayStation SubwayStation { get; set; }

        #endregion

        #region Navigation Properties

        public virtual ICollection<ApartmentOwner> Owners { get; set; }  
        
        #endregion
    }
}
