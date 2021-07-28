using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureShop.Models
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private AppDbContext context;

        public FurnitureRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Furniture> ListFurniture => context.Furniture.ToArray();
        public IEnumerable<CategoryFurniture> ListCategory => context.CategoryFurniture.ToArray();
        public IEnumerable<TypeFurniture> ListType => context.TypeFurniture.ToArray();

        public void Add(Furniture furniture)
        {
            context.Add(furniture);
            context.SaveChanges();
        }

        public Furniture Delete(int furnitureId)
        {
            Furniture dbEntry = context.Furniture.FirstOrDefault(f => f.ID == furnitureId);

            if (dbEntry != null)
            {
                context.Furniture.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

        //public Furniture GetFurniture(long key) => context.Furniture.Find(key);

        public void Update(Furniture furniture)
        {
            context.Furniture.Update(furniture);
            context.SaveChanges();
        }

        public void Save(Furniture furniture)
        {
            if (furniture.ID == 0)
            {
                context.Furniture.Add(furniture);
            }
            else
            {
                Furniture dbEntry = context.Furniture.FirstOrDefault(f => f.ID == furniture.ID);
                if (dbEntry != null)
                {
                    dbEntry.Name = furniture.Name;
                    dbEntry.CategoryID = furniture.CategoryID;
                    dbEntry.TypeID = furniture.TypeID;
                    dbEntry.Price = furniture.Price;
                    dbEntry.Description = furniture.Description;
                    dbEntry.Image = furniture.Image;
                }
            }

            context.SaveChanges();
        }
    }
}
