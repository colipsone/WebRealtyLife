using System.ComponentModel.DataAnnotations.Schema;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public class RegionConfiguration : AuditedEntityTypeConfiguration<Region>
    {
        public RegionConfiguration(): base(DatabaseGeneratedOption.None)
        {
            HasRequired(s => s.City).
                WithMany(c => c.Regions).
                HasForeignKey(a => a.CityId);
        }
    }
}
