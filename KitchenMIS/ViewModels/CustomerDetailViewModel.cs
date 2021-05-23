using System;
using System.ComponentModel.DataAnnotations;
using KitchenMIS.Models;
using Microsoft.AspNetCore.Http;

namespace KitchenMIS.ViewModels
{
    public class CustomerDetailViewModel
    {
        public  Customer Customer { get; set; }
        public  CustomerDetail CustomerDetail { get; set; }

     
    }

   
}
