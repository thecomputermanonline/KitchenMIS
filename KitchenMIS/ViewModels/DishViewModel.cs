using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace KitchenMIS.Models.ViewModels
{
    public class DishViewModel
    {
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

        [Required(ErrorMessage = "Please choose Dish image")]
        public IFormFile DishImage { get; set; }
    }
}
