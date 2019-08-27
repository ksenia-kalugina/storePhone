using Microsoft.EntityFrameworkCore;
using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
        public DbSet<StoreCartItem> StoreCartItem { get; set; }        
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Category> Category { get; set; }       
        public DbSet<User> Users { get; set; }
       
    }
}
