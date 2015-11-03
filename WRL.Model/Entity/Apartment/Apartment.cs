﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WRL.Model.Entity.Apartment
{
    public class Apartment: IEntity, IAuditedEntity
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