﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.ViewModels;

namespace WRL.Model.Entities.Apartment
{
    public class Apartment: IEntity, IAuditedEntity
    {

        #region Fields: Public

        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Address { get; set; }

        #endregion

        #region Methods: Public

        public ApartmentViewModel ToViewModel()
        {
            return new ApartmentViewModel
            {
                CreatedBy = this.CreatedBy,
                CreatedOn = this.CreatedOn,
                UpdatedBy = this.UpdatedBy,
                UpdatedOn = this.UpdatedOn,
                Address = this.Address
            };
        }

        #endregion
    }
}
