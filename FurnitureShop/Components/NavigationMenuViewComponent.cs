using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FurnitureShop.Models;
using System;

namespace FurnitureShop.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IFurnitureRepository repository;

        public NavigationMenuViewComponent(IFurnitureRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            //ViewBag.SelectedCategory = Request.Query.FirstOrDefault(p => p.Key == "category").Value;
            ViewBag.SelectedCategory = RouteData?.Values["categoryID"];
            return View(repository.ListCategory);
        }
    }
}
