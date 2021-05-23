using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitchenMIS.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public List<OrderItem> Orderitems { get; set; } = new List<OrderItem>();
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0!")]
        public int TotalAmount { get; set; }
        [DisplayName("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        

       

    
        
    }
}
