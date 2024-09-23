using Application.Common.Interfaces;
using Application.Services.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.AppCodes;
using Web.Areas.Admin.ViewModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork unitOfWork;
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
        public IActionResult Update(Product product, IFormFile? photo)
        {
            if (photo != null)
            {
                string fileName = $"{DateTime.Now.Ticks}_{photo.FileName}"; //File name
                string folder = Path.Combine(ApplicationContext.WebRootPath, @"assets\images\products"); //File Path
                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
                product.ImageUrl = fileName;
            }

            _productService.UpdateProduct(product);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        public IActionResult ProductColor(int id, string method="", int colorId)
        {
            switch (method)
            {

            }
        }
    }
}
