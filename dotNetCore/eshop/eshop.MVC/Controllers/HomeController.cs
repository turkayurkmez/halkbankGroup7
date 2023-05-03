using eshop.Application;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;

        }

        public async Task<IActionResult> Index()
        {


            //var products = new List<Product>
            //{
            //    new Product{ Id=1, Name="AAA", Description="Sample of text", DiscountRate=0.15, Price=250},
            //    new Product{ Id=2, Name="BBB", Description="Sample of text 2", DiscountRate=0.25, Price=1250},
            //    new Product{ Id=3, Name="CCC", Description="Sample of text 3", DiscountRate=0.15, Price=2250}

            //};

            // var productService = new ProductService();
            var products = await _productService.GetProductsAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}