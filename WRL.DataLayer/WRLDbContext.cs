using Microsoft.AspNet.Identity.EntityFramework;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Migrations;
using WRL.Model.Entity.Apartment;
using WRL.Model.Entity.Security;

namespace WRL.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

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

        //public virtual IDbSet<ApplicationUser> ApplicationUsers { get; set; }

        #endregion
    }
}