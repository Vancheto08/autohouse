using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AutohouseContext : DbContext
    {
        public AutohouseContext():base("name=AutohouseContext")
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
