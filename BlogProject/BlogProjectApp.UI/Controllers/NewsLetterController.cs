using BlogProjectApp.Business.Abstract;
using BlogProjectApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
	public class NewsLetterController : Controller
	{
		private readonly INewsLetterService _newsletterService;

		public NewsLetterController(INewsLetterService newsletterService)
		{
			_newsletterService = newsletterService;
		}

		[HttpGet]
		public PartialViewResult SubscribeMailPartial()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SubscribeMailPartial(NewsLetter p)
		{
			p.Status = true;
			_newsletterService.Add(p);
			return PartialView();
		}
	}
}
