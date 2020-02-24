using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SatisSistemi.Utility
{
    public interface ICrudEntity<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IList<TEntity> Get(Expression<Func<TEntity,bool>> filter);
        IList<TEntity> GetList(Expression<Func<TEntity,bool>> filter=null);

    }
}
