using WRL.Model.Entities.Apartment;

namespace WRL.DataLayer.Interfaces
{
    public interface IWrlDbContext
    {
        IDbSet<Apartment> Apartments { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
