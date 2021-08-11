using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FurnitureShop.Models;
using System;

namespace FurnitureShop.Components
{
    public class TypeViewComponent: ViewComponent
    {
        private IFurnitureRepository repository;

        public TypeViewComponent(IFurnitureRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["typeID"];
            return View(repository.ListType.Where(t => t.CategoryID == Convert.ToInt32(TempData["CategoryID"])));
        }
    }
}
