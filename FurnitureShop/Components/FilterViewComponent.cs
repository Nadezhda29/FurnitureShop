using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FurnitureShop.Models;
using System;

namespace FurnitureShop.Components
{
    public class FilterViewComponent: ViewComponent
    {
        private IFurnitureRepository repository;

        public FilterViewComponent(IFurnitureRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            int category = Convert.ToInt32(TempData.Peek("CategoryID"));
            TempData["minPrice"] = repository.ListFurniture.Where(f => f.CategoryID == category).Select(f => f.Price).Min();
            TempData["maxPrice"] = repository.ListFurniture.Where(f => f.CategoryID == category).Select(f => f.Price).Max();
            return View(repository.ListType.Where(t => t.CategoryID == Convert.ToInt32(TempData["CategoryID"])));
        }
    }
}
