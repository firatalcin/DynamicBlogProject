using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
	public class ContactController : Controller
	{
		private readonly IContactDal _contactDal;


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			contact.Status = true;
			_contactDal.Add(contact);
			return RedirectToAction("Index", "Blog");
		}
	}
}
