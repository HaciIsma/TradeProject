using System.Collections.Generic;

namespace TradeProject.Repository.Interface
{
    public interface IRepoDaily<T>
    {
        void Add(T entity);
        List<T> GetAll();
    }
}
