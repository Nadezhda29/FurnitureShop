using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureShop.Models;

namespace FurnitureShop.Controllers
{
    public class HomeController : Controller
    {
        private IFurnitureRepository repository;

        public HomeController(IFurnitureRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository);
        }
    }
}
