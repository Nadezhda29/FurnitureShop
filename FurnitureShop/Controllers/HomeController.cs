using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureShop.Models;
using FurnitureShop.Models.ViewModels;

namespace FurnitureShop.Controllers
{
    public class HomeController : Controller
    {
        private IFurnitureRepository repository;

        public HomeController(IFurnitureRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int categoryID)
        {
            return View(new FurnitureListViewModel
            {
                Furniture = repository.ListFurniture
                 //.Where(f => f.CategoryID == categoryID)
                 //.OrderBy(f => f.ID),

                //CurrentCategory = repository.ListCategory
                // .FirstOrDefault(c => c.ID == categoryID).Category
            });
        }
    }
}
