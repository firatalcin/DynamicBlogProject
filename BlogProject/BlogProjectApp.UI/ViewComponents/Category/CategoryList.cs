using BlogProjectApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.UI.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		private readonly ICategoryService _categoryService;

		public CategoryList(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _categoryService.GetList();
			return View(values);
		}
	}
}
