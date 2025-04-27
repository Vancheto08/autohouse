using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AutohouseContext : DbContext
    {
        public AutohouseContext() : base("name=AutohouseContext")
        {

        }
        public AutohouseContext(DbConnection connection):base(connection, true)
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Car>()
                .HasKey(oc => new { oc.OrderId, oc.CarId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Car> Orders_Cars { get; set; }
    }
}
