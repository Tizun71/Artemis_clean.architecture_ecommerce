using Application.Services.Implementation;
using Application.Services.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.AppCodes
{
    public class SelectListHelper
    {
        private readonly ICategoryService _categoryService;

        public SelectListHelper(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public List<SelectListItem> Categories()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem
            {
                Value = "",
                Text = "-- Chọn danh mục --"
            });
            foreach (var item in _categoryService.GetAllCategories())
            {
                list.Add(new SelectListItem()
                {
                    Value = item.CategoryID.ToString(),
                    Text = item.CategoryName,
                });
            }
            return list;
        }
    }
}
