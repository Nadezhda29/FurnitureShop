using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureShop.Models;
using FurnitureShop.Models.ViewModels;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

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
            return View();
        }

        public ViewResult ListFurniture(int categoryID)
        {
            TempData["CategoryID"] = categoryID;
            return View(new FurnitureListViewModel
            {
                Furniture = repository.ListFurniture
                .Where(f => f.CategoryID == categoryID)
                .OrderBy(f => f.ID),

                CategoryFurniture = repository.ListCategory,
                TypeFurniture = repository.ListType,

                CurrentCategory = categoryID,
            }); 
        }

        public ViewResult FilterList()
        {
            List<Furniture> listFurniture = TempData.Get<List<Furniture>>("list");

            return View("ListFurniture", new FurnitureListViewModel
            {
                Furniture = listFurniture,

                CategoryFurniture = repository.ListCategory,
                TypeFurniture = repository.ListType
            });
        }


        [HttpPost]
        public RedirectToActionResult Filter(IEnumerable<string> checks, string price1, string price2)
        {
            List<Furniture> listFurniture = new List<Furniture>();
            
            foreach (string item in checks)
            {
                listFurniture.AddRange(repository.ListFurniture.Where(f => f.TypeID == Convert.ToInt32(item)
                        && f.Price >= Convert.ToDecimal(price1) && f.Price <= Convert.ToDecimal(price2)));
            }


            TempData.Put("list", listFurniture);
            TempData["CategoryID"] = listFurniture.FirstOrDefault().CategoryID;

            return RedirectToAction("FilterList", "Home");
        }

        public FileContentResult GetImage(int ID)
        {
            Furniture furniture = repository.ListFurniture.Where(f => f.ID == ID).FirstOrDefault();

            return File(furniture.Image, "image/jpg");
        }
    }
}
