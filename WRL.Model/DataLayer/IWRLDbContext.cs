using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.Entities.Apartment;

namespace WRL.Model.DataLayer
{
    public interface IWrlDbContext
    {
        IDbSet<Apartment> Apartments { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
