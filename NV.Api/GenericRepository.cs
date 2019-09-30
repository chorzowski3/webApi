using Microsoft.EntityFrameworkCore;
using NV.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NV.Api
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private AW2016DbContext db = null;
 
        DbSet<T> _objectSet;
        public GenericRepository(AW2016DbContext _db)
        {
            db = _db;
            _objectSet = db.Set<T>();
        }
        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }
        public void Delete(T entity)
        {
            _objectSet.Remove(entity);
        }
        public T GetDetail(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.First(predicate);
        }
        public IEnumerable<T> GetOverview(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
                return _objectSet.Where(predicate);
            return _objectSet.AsEnumerable();
        }

    }


}
