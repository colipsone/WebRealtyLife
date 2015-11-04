using System.ComponentModel.DataAnnotations.Schema;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public class ApartmentConfiguration : AuditedEntityTypeConfiguration<Apartment>
    {
        public ApartmentConfiguration(): base(DatabaseGeneratedOption.None)
        {
            Ignore(a => a.Number);

            HasOptional(a => a.ApartmentType).
                WithMany(at => at.Apartments).
                HasForeignKey(a => a.ApartmentTypeId);

            HasOptional(a => a.SubwayStation).
                WithMany(ss => ss.Apartments).
                HasForeignKey(a => a.SubwayStationId);

            HasRequired(a => a.Street).
                WithMany(s => s.Apartments).
                HasForeignKey(a => a.StreetId);

        }
    }
}
