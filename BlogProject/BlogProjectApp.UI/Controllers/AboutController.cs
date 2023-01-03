using BlogProjectApp.Business.Abstract;
using BlogProjectApp.Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
	public class AboutController : Controller
	{
		private readonly IAboutService _aboutService;

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult SocialMediaAboutPartial()
		{
			var values = _aboutService.GetList();
			return PartialView(values);
		}
	}
}
