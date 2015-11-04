using System;
using WRL.Model.Interface.Entity.Common;

namespace WRL.Model.Interface.Security
{
    public abstract class AuditedEntity: BaseEntity
    {
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
