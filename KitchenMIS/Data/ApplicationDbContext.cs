using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KitchenMIS.Models;

namespace KitchenMIS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KitchenMIS.Models.Customer> Customers { get; set; }
        //public DbSet<KitchenMIS.Models.CustomerDetail> CustomerDetails { get; set; }
        public DbSet<KitchenMIS.Models.Dish> Dishes { get; set; }
        //public DbSet<KitchenMIS.Models.DishIngredient> DishIngredients { get; set; }
        public DbSet<KitchenMIS.Models.Order> Orders { get; set; }
        public DbSet<KitchenMIS.Models.OrderItem> OrderItems { get; set; }
        public DbSet<KitchenMIS.Models.Category> Category { get; set; }
        public DbSet<KitchenMIS.Models.CustomerDetail> CustomerDetail { get; set; }
        public DbSet<KitchenMIS.Models.Expense> Expense { get; set; }
        public DbSet<KitchenMIS.Models.Ingredient> Ingredient { get; set; }
        public DbSet<KitchenMIS.Models.Stock> Stock { get; set; }
        //public DbSet<KitchenMIS.Models.StockItem> StockItems { get; set; }
        //public DbSet<KitchenMIS.Models.Expense> Expenses { get; set; }
        //public DbSet<KitchenMIS.Models.ExpenseType> ExpenseTypes { get; set; }

    }
}
