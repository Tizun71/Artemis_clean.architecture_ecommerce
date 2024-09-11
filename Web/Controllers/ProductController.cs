using Application.Common.Interfaces;
using Application.Services.Interface;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModel;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();

/*            var result = products.Select(p => new ProductViewModel
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                Description = p.ProductDescription,
            });*/
            return View(products);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
