using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NV.Api
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        T GetDetail(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetOverview(Expression<Func<T, bool>> predicate = null);
    }
}
