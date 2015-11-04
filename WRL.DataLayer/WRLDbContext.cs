using Microsoft.AspNet.Identity.EntityFramework;
using WRL.DataLayer.EntitiesConfigurations;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Migrations;
using WRL.Model.Entity.Apartment;
using WRL.Model.Entity.Security;

namespace WRL.DataLayer
{
    using System.Data.Entity;

    public class WrlDbContext : IdentityDbContext<ApplicationUser>, IWrlDbContext 
    {
        #region ctors

        public WrlDbContext()
            : base("name=WRLDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WrlDbContext, Configuration>("WRLDbContext"));
        }

        #endregion

        #region DbSets

        public virtual IDbSet<Apartment> Apartments { get; set; }

        public virtual IDbSet<ApartmentOwner> ApartmentOwners { get; set; }

        public virtual IDbSet<ApartmentType> ApartmentTypes { get; set; }

        public virtual IDbSet<City> Cities { get; set; }

        public virtual IDbSet<Region> Regions { get; set; }

        public virtual IDbSet<Street> Streets { get; set; }

        public virtual IDbSet<SubwayStation> SubwayStations { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            new WrlConfigModelBuilder(modelBuilder).Configure();
            base.OnModelCreating(modelBuilder);
        }
    }
}