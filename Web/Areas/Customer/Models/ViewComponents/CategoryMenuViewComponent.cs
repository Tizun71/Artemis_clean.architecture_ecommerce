using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Customer.Models.ViewModel;
namespace Web.Areas.Customer.Models.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly IUnitOfWork db;
        public CategoryMenuViewComponent(IUnitOfWork context) => db = context;
        public IViewComponentResult Invoke()
        {
            var data = db.Category.List().Select(category => new CategoryMenuViewModel
            {
                CategoryID = category.CategoryID,
                CategoryName = category.CategoryName,
                Quantity = category.Products?.Count() ?? 0,
            });

            return View(data);
        }
    }
}
