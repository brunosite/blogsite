using System.Collections.Generic;

namespace Domain
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ICollection<TEntity> All();
        IList<TEntity> FindById(int id);
        IList<TEntity> FindWhere();
        IEnumerable<TEntity> Update();
        IEnumerable<TEntity> Delete();
    }
}