using BlogProjectApp.Business.Abstract;
using BlogProjectApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IWriterService _writerService;

		public RegisterController(IWriterService writerService)
		{
			_writerService = writerService;
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			_writerService.Add(writer);
			return RedirectToAction("Index");
		}
	}
}
