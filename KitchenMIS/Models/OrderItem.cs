using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitchenMIS.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        [DisplayName("Order")]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [DisplayName("Dish")]
        public int DishId { get; set; }

        [ForeignKey("DishId")]
        public virtual Dish Dish { get; set; }

    }
}