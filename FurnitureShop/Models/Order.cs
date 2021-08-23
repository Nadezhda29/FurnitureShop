using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите улицу, дом и квартиру")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш город")]
        public string City { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Вашу страну")]
        public string Country { get; set; }
    }
}
