using System.ComponentModel.DataAnnotations.Schema;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public class SubwayStationConfiguration: AuditedEntityTypeConfiguration<SubwayStation>
    {
        public SubwayStationConfiguration(): base(DatabaseGeneratedOption.None)
        {
            HasRequired(ss => ss.Region).
                WithMany(ss => ss.SubwayStations).
                HasForeignKey(ss => ss.RegionId).
                WillCascadeOnDelete(false);
        }
    }
}
