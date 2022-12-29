using BlogProjectApp.Business.Abstract;
using BlogProjectApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
	public class CommentController : Controller
	{
		private readonly ICommentService _commentService;

		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
			p.Date= DateTime.Parse(DateTime.Now.ToShortDateString());
			p.Status = true;
			p.BlogId = 1;
			_commentService.Add(p);
            return PartialView();
        }


        public PartialViewResult PartialCommentList(int id)
		{
			var values = _commentService.GetListAllEx(id);
			return PartialView(values);
		}


	}
}
