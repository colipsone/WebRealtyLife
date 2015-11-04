using System;
using System.Data.Entity;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.Interface
{
    public interface IWrlDbContext: IDisposable
    {
        IDbSet<Apartment> Apartments { get; set; }

        IDbSet<ApartmentOwner> ApartmentOwners { get; set; }

        IDbSet<ApartmentType> ApartmentTypes { get; set; }

        IDbSet<City> Cities { get; set; }

        IDbSet<Region> Regions { get; set; }

        IDbSet<Street> Streets { get; set; }

        IDbSet<SubwayStation> SubwayStations { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
