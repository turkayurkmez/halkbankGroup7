using eshop.Application;
using eshop.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
    [Authorize(Roles = "Admin,Editor")]
    public class ProductsController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;


        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }


        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await getCategoriesForSelect();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                await productService.CreateNew(product);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = await getCategoriesForSelect();
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await productService.GetProductAsync(id);
            if (product != null)
            {
                ViewBag.Categories = await getCategoriesForSelect();
                return View(product);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                await productService.Update(product);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = await getCategoriesForSelect();
            return View();
        }



        private async Task<IEnumerable<SelectListItem>> getCategoriesForSelect()
        {
            var categories = await categoryService.GetCategories();
            var selectList = categories.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            return selectList;
        }
    }
}
