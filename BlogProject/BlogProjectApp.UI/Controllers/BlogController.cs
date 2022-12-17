using BlogProjectApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = _blogService.GetBlogListWithCategory();
            return View(list);
        }

        public IActionResult BlogDetail(int id)
        {
            var list = _blogService.GetBlogById(id);
            return View(list);
        }
    }
}
