using System.Collections.Generic;
using FurnitureShop.Models;

namespace FurnitureShop.Models.ViewModels
{
    public class FurnitureListViewModel
    {
        public IEnumerable<Furniture> Furniture { get; set; }
        public string CurrentCategory { get; set; }
    }
}
