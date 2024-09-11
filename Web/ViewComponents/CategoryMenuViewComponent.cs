using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModel;
namespace Web.ViewComponents
{
	public class CategoryMenuViewComponent : ViewComponent
	{
		private readonly ApplicationDbContext db;
		public CategoryMenuViewComponent(ApplicationDbContext context) => db = context;
		public IViewComponentResult Invoke()
		{
			var data = db.Categories.Select(category => new CategoryMenuViewModel
			{
				CategoryID = category.CategoryID,
				CategoryName = category.CategoryName,
				Quantity = category.Products.Count(),
			});

			return View(data);
		}
	}
}
