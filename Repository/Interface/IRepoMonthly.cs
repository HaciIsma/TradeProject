﻿using System.Collections.Generic;

namespace TradeProject.Repository.Interface
{
    public interface IRepoMonthly<T>
    {
        void Add(T entity);
        List<T> GetAll();
    }
}
