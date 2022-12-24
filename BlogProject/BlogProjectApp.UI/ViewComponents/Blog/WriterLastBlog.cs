using BlogProjectApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		private IBlogService _blogService;

		public WriterLastBlog(IBlogService blogService)
		{
			_blogService = blogService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _blogService.GetBlogListByWriter(1);
			return View(values);
		}
	}
}
