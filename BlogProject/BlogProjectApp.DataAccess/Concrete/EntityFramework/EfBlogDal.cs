using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.DataAccess.Context;
using BlogProjectApp.DataAccess.Repositories;
using BlogProjectApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogProjectApp.DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : RepositoryBase<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new ProjectDbContext())
            {
                return context.Blogs.Include(b => b.Category).ToList();
            }
        }
    }
}
