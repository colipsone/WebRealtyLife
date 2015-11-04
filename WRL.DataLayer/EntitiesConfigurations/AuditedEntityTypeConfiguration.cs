using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WRL.Model.Interface.Entity.Common;
using WRL.Model.Interface.Security;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public abstract class AuditedEntityTypeConfiguration<TEntity> : EntityTypeConfiguration<TEntity>
        where TEntity : AuditedEntity
    {
        protected AuditedEntityTypeConfiguration(DatabaseGeneratedOption databaseGeneratedOption = DatabaseGeneratedOption.Identity)
        {
            HasKey(e => e.Id);
            Property(e => e.Id).HasDatabaseGeneratedOption(databaseGeneratedOption);
            Property(a => a.CreatedBy).IsOptional();
            Property(a => a.CreatedOn).IsOptional();
            Property(a => a.UpdatedBy).IsOptional();
            Property(a => a.UpdatedOn).IsOptional();
        }
    }
}
