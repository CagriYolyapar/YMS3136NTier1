using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    class MyContext : DbContext
    {
        public MyContext() : base("MyConnect")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /* modelBuilder.Configurations.Add(new AppUserMap());
             modelBuilder.Configurations.Add(new ProfileMap());
             modelBuilder.Configurations.Add(new OrderMap());
             modelBuilder.Configurations.Add(new OrderDetailMap());
             modelBuilder.Configurations.Add(new CategoryMap());
             modelBuilder.Configurations.Add(new ProductMap());
             modelBuilder.Configurations.Add(new ShipperMap());
              */
            // entegereden sonra yazılacak dbsetler
            //tool sekmesinden package manager console açılıp
            //enable-migrations -enableautomaticmigrations
            //update-database
        }
        public  DbSet<AppUser> AppUsers { get; set; }        
        public DbSet<AppUserDetail> AppUserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
 
    }
}
