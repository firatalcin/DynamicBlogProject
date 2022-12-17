using BlogProjectApp.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.DataAccess.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void Add(T entity)
        {
            using (ProjectDbContext db = new ProjectDbContext())
            {
                db.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ProjectDbContext db = new ProjectDbContext())
            {
                db.Remove(entity);
                db.SaveChanges();
            }
        }

        public List<T> GetListAll()
        {
            using (ProjectDbContext db = new ProjectDbContext())
            {
                return db.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (ProjectDbContext db = new ProjectDbContext())
            {
                return db.Set<T>().Find(id);
            }
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using (ProjectDbContext db = new ProjectDbContext())
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (ProjectDbContext db = new ProjectDbContext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }
    }
}
