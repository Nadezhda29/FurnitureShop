using Microsoft.AspNetCore.Mvc;
using FurnitureShop.Models;
using FurnitureShop.Models.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

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

        public ViewResult Add(Furniture furniture) => View("AddFurniture", new Furniture());

        public ViewResult Edit(int furnitureId)
        {
            return View(repository.ListFurniture.FirstOrDefault(f => f.ID == furnitureId));
        }

        [HttpPost]
        public IActionResult Edit(Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                repository.Save(furniture);
                TempData["message"] = $"{furniture.Name} has been saved.";
                return RedirectToAction("Index");
            }
            else
            {
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
    }
}
