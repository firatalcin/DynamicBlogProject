using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.DataAccess.Repositories;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : RepositoryBase<Blog>, IBlogDal
    {
    }
}
