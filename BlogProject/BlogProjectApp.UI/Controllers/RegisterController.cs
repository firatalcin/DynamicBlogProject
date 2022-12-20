using BlogProjectApp.Business.Abstract;
using BlogProjectApp.Business.ValidationRules;
using BlogProjectApp.Entities.Concrete;
using FluentValidation.Results;
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
			WriterValidator vr = new WriterValidator();
			ValidationResult result= vr.Validate(writer);
			if (result.IsValid)
			{
                writer.Status = true;
                writer.About = "Deneme Test";
                _writerService.Add(writer);
                return RedirectToAction("Index");
            }
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
			
		}
	}
}
