using System;

namespace WRL.Web.Models.ApartmentService
{
    public class ApartmentViewModel
    {
        #region Fields: Public

        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Address { get; set; }

        #endregion
    }
}
