using API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tesodev.Webservices.Data.Helper;

namespace Tesodev.Webservices.Data.Concrete.Contexts
{
    public class TesodevdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=tesodevdb; integrated security=true;");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Addess> Addesses { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
