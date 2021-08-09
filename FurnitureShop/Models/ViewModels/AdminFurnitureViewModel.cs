using System.Collections.Generic;

namespace FurnitureShop.Models.ViewModels
{
    public class AdminFurnitureViewModel
    {
        public IEnumerable<Furniture> Furniture { get; set; }
        public IEnumerable<TypeFurniture> TypeFurniture { get; set; }
        public IEnumerable<CategoryFurniture> CategoryFurniture { get; set; }
    }
}
