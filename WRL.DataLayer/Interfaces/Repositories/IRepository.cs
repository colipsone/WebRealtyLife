using System.Collections.Generic;
using WRL.Model.Entities;

namespace WRL.DataLayer.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity: class, IEntity, new()
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(int id);
        void SaveChanges();
    }
}
