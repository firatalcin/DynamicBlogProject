using BlogProjectApp.Business.Repositories;
using BlogProjectApp.Entities.Concrete;
using System.Linq.Expressions;

namespace BlogProjectApp.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> GetListAllEx(int id);
    }
}
