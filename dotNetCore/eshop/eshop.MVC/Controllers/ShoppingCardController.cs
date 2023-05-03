using eshop.Application;
using eshop.Entities;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace eshop.MVC.Controllers
{
    public class ShoppingCardController : Controller
    {
        private readonly IProductService _productService;

        public ShoppingCardController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var collection = getFromSession();
            return View(collection);
        }

        public async Task<IActionResult> AddProduct(int id)
        {
            Product product = await _productService.GetProductAsync(id);
            ShoppingCardCollection myBasket = getFromSession();
            myBasket.AddProduct(new ShoppingCardItem { Product = product, Quantity = 1 });
            saveToSession(myBasket);

            return Json(new { message = $"{product.Name} isimli ürün sepete eklendi..." });
        }

        private void saveToSession(ShoppingCardCollection myBasket)
        {
            var serializedObj = JsonSerializer.Serialize(myBasket);
            HttpContext.Session.SetString("basket", serializedObj);

        }


        private ShoppingCardCollection getFromSession()
        {

            var jsonSerialized = HttpContext.Session.GetString("basket");
            if (jsonSerialized != null)
            {
                return JsonSerializer.Deserialize<ShoppingCardCollection>(jsonSerialized);
            }

            return new ShoppingCardCollection();

        }
    }
}
