using Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Customer.Controllers
{
    [Area("Customer")]
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

        public IActionResult Detail()
        {
            return View();
        }
    }
}
