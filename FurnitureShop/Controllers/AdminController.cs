using Microsoft.AspNetCore.Mvc;
using FurnitureShop.Models;
using FurnitureShop.Models.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;

namespace FurnitureShop.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IFurnitureRepository repository;

        public AdminController(IFurnitureRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int categoryID)
        {
            return View(new FurnitureListViewModel
            {
                Furniture = repository.ListFurniture
                // .Where(f => f.CategoryID == categoryID)
                // .OrderBy(f => f.ID),

                //CurrentCategory = repository.ListCategory
                // .FirstOrDefault(c => c.ID == categoryID).Category
            });
        }

        public ViewResult Add(Furniture furniture)
        {
            ViewBag.Title = "Добавление";
            return View("Edit", new Furniture());
        } 

        public ViewResult Edit(int furnitureId)
        {
            ViewBag.Title = "Редактирование";
            return View(repository.ListFurniture.FirstOrDefault(f => f.ID == furnitureId));
        }

        [HttpPost]
        public IActionResult Edit(Furniture furniture, byte[] bytesImage)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Модель правиьна");

                //byte[] bytes;
                //Stream stream = file.OpenReadStream();
                //BinaryReader reader = new BinaryReader(stream);

                //bytes = reader.ReadBytes((int)stream.Length);

                furniture.Image = bytesImage;


                repository.Save(furniture);
                TempData["message"] = $"{furniture.Name} has been saved.";
                return RedirectToAction("Index");
            }
            else
            {
                Console.WriteLine("Модель невалидна");
                return View(furniture);
            }
        }

        [HttpPost]
        public IActionResult Delete(int furnitureId)
        {
            Furniture deletedFurniture = repository.Delete(furnitureId);
            if (deletedFurniture != null)
            {
                TempData["message"] = $"{deletedFurniture.Name} was deleted";
            }

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //public RedirectToActionResult ConvertImage(IFormFile image)
        //{
        //    byte[] bytes;
        //    Stream stream = image.OpenReadStream();
        //    BinaryReader reader = new BinaryReader(stream);

        //    bytes = reader.ReadBytes((int)stream.Length);

        //    return RedirectToAction(nameof(Edit), bytes);
        //}
    }
}
