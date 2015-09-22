using WRL.Model.DataLayer;
using WRL.Model.Entities.Apartment;
using IWrlDbContext = WRL.DataLayer.Interfaces.IWrlDbContext;

namespace WRL.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WrlDbContext : DbContext, IWrlDbContext
    {
        #region ctors

        public WrlDbContext()
            : base("name=WRLDbContext")
        {
        }

        #endregion

        #region DbSets

        public virtual IDbSet<Apartment> Apartments { get; set; }

        #endregion
    }
}