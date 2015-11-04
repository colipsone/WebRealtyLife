using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Interface.Repository;
using WRL.Model.Interface.Entity.Common;

namespace WRL.DataLayer.Common
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        #region Fields: Private

        private readonly IWrlDbContext _context;

        private readonly Lazy<DbSet<TEntity>> _dbSetLazy; 

        private DbSet<TEntity> DbSet => _dbSetLazy.Value;

        #endregion

        #region Ctors

        public Repository(IWrlDbContext context)
        {
            _context = context;
            _dbSetLazy = new Lazy<DbSet<TEntity>>(context.Set<TEntity>);
        }

        #endregion

        #region Methods: Public

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(Guid id)
        {
            var entityToDelete = DbSet.FirstOrDefault(ent => ent.Id == id);
            if (entityToDelete != null)
            {
                DbSet.Remove(entityToDelete);
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.OfType<TEntity>();
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.FirstOrDefault(ent => ent.Id == id);
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.AddOrUpdate();
        }

        #endregion
    }
}
