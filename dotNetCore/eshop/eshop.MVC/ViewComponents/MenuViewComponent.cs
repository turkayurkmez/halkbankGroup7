﻿using eshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.ViewComponents
{

    public class MenuViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;


        public MenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategories().Result;
            return View(categories);
        }
    }
}
