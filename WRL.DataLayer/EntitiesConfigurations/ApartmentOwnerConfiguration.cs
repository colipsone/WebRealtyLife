using System.ComponentModel.DataAnnotations.Schema;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public class ApartmentOwnerConfiguration : AuditedEntityTypeConfiguration<ApartmentOwner>
    {
        public ApartmentOwnerConfiguration(): base(DatabaseGeneratedOption.None)
        {
            HasRequired(ao => ao.Apartment).
                WithMany(a => a.Owners).
                HasForeignKey(ao => ao.ApartmentId);
        }
    }
}
