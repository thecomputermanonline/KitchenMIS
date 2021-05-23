using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitchenMIS.Models
{
    public class Category
    {
        

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
