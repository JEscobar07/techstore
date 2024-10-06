using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techstore.Models;

namespace techstore.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Rol> Roles {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<StateOrder> StateOrders {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<OrderProduct> OrderProducts {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        
        
    }
}