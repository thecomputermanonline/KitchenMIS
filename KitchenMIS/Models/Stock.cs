using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitchenMIS.Models
{
    public class Stock
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]

        public string item { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("Category")]

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string initialstock { get; set; }

        [Required(ErrorMessage = "{0} is required")]  
        public string restocklevel { get; set; }
        
    }
}
