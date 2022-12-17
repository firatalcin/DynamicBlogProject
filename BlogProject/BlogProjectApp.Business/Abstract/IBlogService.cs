using BlogProjectApp.Business.Repositories;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogById(int id);
    }
}
