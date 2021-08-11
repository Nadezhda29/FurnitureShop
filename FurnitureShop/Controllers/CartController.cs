using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FurnitureShop.Models;
using FurnitureShop.Models.ViewModels;

namespace FurnitureShop.Controllers
{
    public class CartController : Controller
    {
        private IFurnitureRepository repository;
        private Cart cart;

        public CartController(IFurnitureRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public RedirectToActionResult AddToCart(int furnitureId/*, string returnUrl*/)
        {
            Furniture furniture = repository.ListFurniture.FirstOrDefault(f => f.ID == furnitureId);

            if (furniture != null)
            {
                cart.AddItem(furniture, 1);
            }

            return RedirectToAction("Index", "Cart"/*, new { returnUrl }*/);
        }

        public RedirectToActionResult RemoveFromCart(int furnitureId/*, string returnUrl*/)
        {
            Furniture furniture = repository.ListFurniture.FirstOrDefault(f => f.ID == furnitureId);

            if (furniture != null)
            {
                cart.RemoveLine(furniture);
            }

            return RedirectToAction("Index", "Cart"/*, new { returnUrl }*/);
        }


        //public ViewResult Index(string returnUrl)
        //{
        //    return View(new CartIndexViewModel
        //    {
        //        Cart = cart,
        //        ReturnUrl = returnUrl
        //    });
        //}

        public ViewResult Index()
        {
            return View(new CartIndexViewModel
            {
                Cart = cart
                //ReturnUrl = returnUrl
            });
        }
    }
}
