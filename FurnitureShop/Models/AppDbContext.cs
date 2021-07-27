using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }
        public DbSet<Furniture> Furniture { get; set; }
        public DbSet<TypeFurniture> TypeFurniture { get; set; }
        public DbSet<CategoryFurniture> CategoryFurniture { get; set; }
    }
}
