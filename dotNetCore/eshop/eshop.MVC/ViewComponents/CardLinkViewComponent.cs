using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace eshop.MVC.ViewComponents
{
    public class CardLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var collection = getFromSession();
            return View(collection);
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
