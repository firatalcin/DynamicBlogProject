﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.DataAccess.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetListAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
