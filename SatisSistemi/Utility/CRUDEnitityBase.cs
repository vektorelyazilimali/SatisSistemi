using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatisSistemi.Entity;
using System.Data.Entity;
namespace SatisSistemi.Utility
{
    public class CRUDEnitityBase<TEntity,TContext>:ICrudEntity<TEntity>
        where TEntity:class,new()
        where TContext:DbContext, new()

    {
        // Bağlantılı 
        private TContext _context;

        public CRUDEnitityBase() {
            _context = new TContext();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var find = _context.Set<TEntity>().Find(entity);
            find = entity;
            _context.SaveChanges();
        }

        public IList<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).ToList();
        }

        public IList<TEntity> GetList(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }
    }
}
