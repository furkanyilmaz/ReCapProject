using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: DB tabloları ile proje classlarını bağlamak
    public class CarRentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database= CarRent;Trusted_Connection=true;");
        }

        public DbSet<Car> Car { get; set; }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}
