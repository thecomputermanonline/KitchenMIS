using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KitchenMIS.Models
{
    public class Dish
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Dish Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]

        public string DishName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(350, MinimumLength = 50,
       ErrorMessage = "Dish Name should be minimum 50 characters and a maximum of 350 characters")]

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        public string Recipe { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please choose Dish image")]
        public string DishImage { get; set; }

        
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
