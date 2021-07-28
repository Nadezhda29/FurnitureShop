using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class Furniture
    {
        public long ID { get; set; }

        [Required(ErrorMessage = "Please enter a furniture name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a furniture type")]
        public int TypeID { get; set; }

        [Required(ErrorMessage = "Please select a furniture category")]
        public int CategoryID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a furniture description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please paste a furniture image")]
        public byte[] Image { get; set; }
    }
}
