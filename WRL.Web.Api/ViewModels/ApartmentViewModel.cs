using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WRL.Web.Api.ViewModels
{
    public class ApartmentViewModel
    {
        #region Fields: Public

        public Guid Id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Address { get; set; }

        #endregion
    }
}