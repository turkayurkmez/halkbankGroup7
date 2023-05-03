using eshop.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
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

        private async Task<IEnumerable<SelectListItem>> getCategoriesForSelect()
        {
            var categories = await categoryService.GetCategories();
            var selectList = categories.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            return selectList;
        }
    }
}
