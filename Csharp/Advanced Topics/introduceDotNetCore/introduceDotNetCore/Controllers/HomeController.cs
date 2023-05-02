using introduceDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduceDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;
            ViewBag.Products = new List<string> { "A", "B", "C", "D" };

            var products = new List<Product>()
            {
                 new(){ Id=1, Name="Şapka", Description="Yazlık", Price=150 },
                 new(){ Id=2, Name="Güneş gözlüğü ", Description="4 Mevsimlik", Price=750 },
                 new(){ Id=3, Name="Tişört", Description="Yazlık", Price=250 }


            };


            return View(products);
        }
        //[HttpGet]
        public IActionResult NewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewProduct(Product product)
        {

            if (ModelState.IsValid)
            {
                return View("Result", product);
            }
            return View();
        }
    }


}
