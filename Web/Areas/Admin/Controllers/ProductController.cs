using Application.Services.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Areas.Admin.ViewModel;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var product = _productService.GetAllProducts();
            return View(product);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Create()
        {
            ProductViewModel productViewModel = new()
            {
                CategoryList = _categoryService.GetAllCategories().Select(c => new SelectListItem
                {
                    Text = c.CategoryName,
                    Value = c.CategoryID.ToString(),
                })
            };
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.CreateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ProductViewModel productViewModel = new()
            {
                product = _productService.GetProductById(id),
                CategoryList = _categoryService.GetAllCategories().Select(c => new SelectListItem
                {
                    Text = c.CategoryName,
                    Value = c.CategoryID.ToString(),
                })
            };
            if (productViewModel.product == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
