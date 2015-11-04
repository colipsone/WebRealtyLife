using System;
using WRL.Model.Interface.Entity.Common;
using WRL.Model.Interface.Security;

namespace WRL.Model.Entity.Apartment
{
    public class ApartmentOwner: AuditedEntity, ILookup
    {
        #region Simple Type Properties

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        #endregion

        #region Lookup Properties

        public Guid ApartmentId { get; set; }

        public Apartment Apartment { get; set; }

        #endregion
    }
}
