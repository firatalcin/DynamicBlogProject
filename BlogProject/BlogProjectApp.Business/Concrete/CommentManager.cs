using BlogProjectApp.Business.Abstract;
using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public Comment Get(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetListAllEx(int id)
        {
            return _commentDal.GetListAll(x => x.Id == id);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }

		public List<Comment> GetList()
		{
			return _commentDal.GetListAll();
		}
	}
}
