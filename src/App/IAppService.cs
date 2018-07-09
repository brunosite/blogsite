using System.Collections.Generic;

namespace App
{
    public interface IAppService<TEntity> where TEntity : class
    {
        ICollection<TEntity> All();
        IList<TEntity> FindById(int id);
        IList<TEntity> FindWhere();
        IEnumerable<TEntity> Update();
        IEnumerable<TEntity> Delete();
    }
}