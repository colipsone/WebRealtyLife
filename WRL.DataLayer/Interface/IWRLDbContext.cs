using System;
using System.Data.Entity;
using WRL.Model.Entity.Apartment;
using WRL.Model.Entity.Security;

namespace WRL.DataLayer.Interface
{
    public interface IWrlDbContext: IDisposable
    {
        IDbSet<Apartment> Apartments { get; set; }

        //IDbSet<ApplicationUser> ApplicationUsers { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
