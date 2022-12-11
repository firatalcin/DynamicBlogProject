using BlogProjectApp.Business.Repositories;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
    }
}
