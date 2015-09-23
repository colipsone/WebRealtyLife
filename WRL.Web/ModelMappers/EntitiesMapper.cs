using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WRL.Model.Entity.Apartment;
using WRL.Web.Models.ApartmentService;

namespace WRL.Web.ModelMappers
{
    public static class EntitiesMapper
    {
        public static ApartmentViewModel ToViewModel(this Apartment entity)
        {
            return new ApartmentViewModel
            {
                Address = entity.Address,
                CreatedBy = entity.CreatedBy,
                CreatedOn = entity.CreatedOn,
                UpdatedOn = entity.UpdatedOn,
                UpdatedBy = entity.UpdatedBy
            };
        }
    }
}