using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.DataAccess.Repositories;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : RepositoryBase<Comment>, ICommentDal
    {
    }
}
