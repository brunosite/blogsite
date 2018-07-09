using System.Collections.Generic;
using Domain;

namespace Data
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity: class 
    {
        public ICollection<TEntity> All()
        {
            throw new System.NotImplementedException();
        }

        public IList<TEntity> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<TEntity> FindWhere()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> Update()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}