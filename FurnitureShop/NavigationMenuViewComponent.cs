using Microsoft.AspNetCore.Mvc;
using FurnitureShop.Models;
using System.Linq;

namespace FurnitureShop
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
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.ListFurniture
                .Select(f => f.CategoryID)
                .Distinct()
                .OrderBy(f =>f));
        }
    }
}
