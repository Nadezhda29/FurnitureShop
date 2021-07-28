using System.Collections.Generic;

namespace FurnitureShop.Models
{
    public interface IFurnitureRepository
    {
        IEnumerable<Furniture> ListFurniture { get; }
        IEnumerable<CategoryFurniture> ListCategory { get; }
        IEnumerable<TypeFurniture> ListType { get; }

        void Add(Furniture furniture);

        //Furniture GetFurniture(long key);

        void Update(Furniture furniture);

        Furniture Delete(int furnitureId);

        void Save(Furniture furniture);
    }
}
