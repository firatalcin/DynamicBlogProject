using BlogProjectApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentListByBlog(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _commentService.GetListAllEx(2);
            return View(values);
        }
    }
}
