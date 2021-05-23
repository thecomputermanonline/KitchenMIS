using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitchenMIS.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string item { get; set; }
        public string qty { get; set; }

        [DisplayName("Dish")]
        public int DishId { get; set; }

        [ForeignKey("DishId")]
        public virtual Dish Dish { get; set; }

       
    }
}
