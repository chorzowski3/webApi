using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NV.Api
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        T GetDetail(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetOverview(Expression<Func<T, bool>> predicate = null);
    }
}