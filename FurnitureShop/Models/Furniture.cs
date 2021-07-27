namespace FurnitureShop.Models
{
    public class Furniture
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
