using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		public PartialViewResult PartialCommentList()
		{
			return PartialView();
		}


	}
}
