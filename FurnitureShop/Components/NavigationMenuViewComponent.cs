using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FurnitureShop.Models;

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
            ViewBag.SelectedCategory = RouteData?.Values["categoryID"];
            return View(repository.ListCategory);
        }
    }
}
