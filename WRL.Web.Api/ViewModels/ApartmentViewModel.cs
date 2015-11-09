using System;

namespace WRL.Web.Api.ViewModels
{
    public class ApartmentViewModel
    {
        #region Fields: Public

        public Guid Id { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int FloorNumber { get; set; }

        public int FloorsAmount { get; set; }

        public int Square { get; set; }

        public string HouseNumber { get; set; }

        public int RoomsNumber { get; set; }

        public string Price { get; set; }

        public string Note { get; set; }

        public string StreetName { get; set; }

        public string ApartmentTypeName { get; set; }

        public string SubwayStationName { get; set; }
        
        #endregion
    }
}