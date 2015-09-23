using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRL.Model.Entity
{
    public interface IAuditedEntity
    {
        int CreatedBy { get; set; }
        int UpdatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}
