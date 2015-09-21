using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WRL.Model.Entities;

namespace WRL.Model.DataLayer
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
