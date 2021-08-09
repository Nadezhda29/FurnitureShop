using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class Furniture
    {
        public long ID { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название мебели")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите тип мебели")]
        public int TypeID { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите категорию")]
        public int CategoryID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите цену")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Пожалуйста, прикрепите картинку")]
        public byte[] Image { get; set; }
    }
}
