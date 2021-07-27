using System.Collections.Generic;

namespace FurnitureShop.Models
{
    public interface IFurnitureRepository
    {
        IEnumerable<Furniture> ListFurniture { get; }
    }
}
