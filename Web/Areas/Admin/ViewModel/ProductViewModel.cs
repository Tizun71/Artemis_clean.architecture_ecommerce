using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace Web.Areas.Admin.ViewModel
{
    public class ProductViewModel
    {
        public Product? product;
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
