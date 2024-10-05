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
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        
        
    }
}