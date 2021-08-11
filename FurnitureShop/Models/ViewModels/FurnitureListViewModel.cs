using System.Collections.Generic;
using FurnitureShop.Models;

namespace FurnitureShop.Models.ViewModels
{
    public class FurnitureListViewModel
    {
        public IEnumerable<Furniture> Furniture { get; set; }
        public IEnumerable<CategoryFurniture> CategoryFurniture { get; set; }
        public IEnumerable<TypeFurniture> TypeFurniture { get; set; }
        public int CurrentCategory { get; set; }
    }
}
