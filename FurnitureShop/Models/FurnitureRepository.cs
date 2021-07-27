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
    }
}
