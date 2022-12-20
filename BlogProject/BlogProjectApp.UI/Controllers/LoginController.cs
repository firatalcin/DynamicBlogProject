using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
