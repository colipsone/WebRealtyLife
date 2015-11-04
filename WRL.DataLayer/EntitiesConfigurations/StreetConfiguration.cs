using System.ComponentModel.DataAnnotations.Schema;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public class StreetConfiguration : AuditedEntityTypeConfiguration<Street>
    {
        public StreetConfiguration(): base(DatabaseGeneratedOption.None)
        {
            HasRequired(s => s.Region).
                WithMany(r => r.Streets).
                HasForeignKey(a => a.RegionId);

        }
    }
}
