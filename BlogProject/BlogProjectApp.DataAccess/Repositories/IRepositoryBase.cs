using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.DataAccess.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetListEx(Expression<Func<T, bool>> filter);
    }
}
