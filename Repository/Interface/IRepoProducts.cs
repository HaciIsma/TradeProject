using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TradeProject.Repository.Interface
{
    public interface IRepoProducts<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(Expression<Func<T, bool>> filter);
        List<T> GetAll();
    }
}
