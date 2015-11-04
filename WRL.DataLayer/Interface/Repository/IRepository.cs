using System;
using System.Collections.Generic;
using WRL.Model.Interface.Entity.Common;

namespace WRL.DataLayer.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity: BaseEntity, new()
    {
        void Add(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(Guid id);
        void SaveChanges();
    }
}
