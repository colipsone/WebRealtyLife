using System;
using System.Data.Entity;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.Interface
{
    public interface IWrlDbContext: IDisposable
    {
        IDbSet<Apartment> Apartments { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
