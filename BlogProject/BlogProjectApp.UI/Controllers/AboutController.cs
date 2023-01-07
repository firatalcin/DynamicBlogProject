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
			var values = _aboutService.GetList();
			return View();
		}

		public PartialViewResult SocialMediaAboutPartial()
		{
			
			return PartialView();
		}
	}
}
