using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitchenMIS.Models
{
    public class CustomerDetail
    {
        public int Id { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public string Faith { get; set; }
        public int Spice { get; set; }
        public string Protein { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; } //expat student


        [DisplayName("FavoriteDish")]
        public int DishId { get; set; }
        [ForeignKey("DishId")]
        public virtual Dish Dish { get; set; }

       

        [DisplayName("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
