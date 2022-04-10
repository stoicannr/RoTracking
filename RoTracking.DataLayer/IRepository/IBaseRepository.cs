﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(Guid id);
        void Add(T entity);
        void Remove(Guid id);
        void Update(T entity);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Save();

    }
}
