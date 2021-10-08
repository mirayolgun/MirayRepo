using API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesodev.Webservices.Data.Helper
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                ImageUrl = "tasarimcicek.jpg",
                Name = "Pembe incili Kutuda Renkli Lisyantus",
                OrderId = 1
            },
            new Product
            {
                Id = 2,
                ImageUrl = "dogumgunucicekleri.jpg",
                Name = "Mutluluk Kutusu",
                OrderId = 3
            },
            new Product
            {
                Id = 3,
                ImageUrl = "cicekbuketleri.jpg",
                Name = "Pembe Papatyalı Çiçek Buketi",
                OrderId = 2
            }
         );


            modelBuilder.Entity<Addess>().HasData(
             new Addess
             {
                 Id = 1,
                 AddressLine = "Ayaş Ankara Yolu Blv. No:93, 06796 ",
                 Country = "Türkiye",
                 City = "Ankara",
                 CityCode = "312",
                 CustomerId = 1,
                 OrderId = 3
             },
             new Addess
             {
                 Id = 2,
                 AddressLine = "123 Main Street Room 22",
                 Country = "ABD",
                 City = "New York",
                 CityCode = "212",
                 CustomerId = 2,
                 OrderId = 2
             },
             new Addess
             {
                 Id = 3,
                 AddressLine = "221B Baker Street",
                 Country = "İngiltere",
                 City = "Londra",
                 CityCode = "212",
                 CustomerId = 3,
                 OrderId = 1
             }
        );


            modelBuilder.Entity<Customer>().HasData(
           new Customer
           {
               Id = 1,
               Name = "Mehmet Hatay",
               Email = "mehmethatay@gmail.com",
               
           },
           new Customer
           {
               Id = 2,
               Name = "Doğan Bulut",
               Email = "doganbulut@gmail.com",
               
           },
           new Customer
           {
               Id = 3,
               Name = "Una Stubbs",
               Email = "unastubbs@hotmail.com",
           }
       );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    Quantity = 2,
                    Price = 80,
                    Status = "kargoya verildi",
                    CustomerId = 3,
                },
                new Order
                {
                    Id = 2,
                    Quantity = 1,
                    Price = 100,
                    Status = "İptal edildi",
                    CustomerId = 2,
                    
                },
                new Order
                {
                    Id = 3,
                    Quantity = 4,
                    Price = 150,
                    Status = "Teslim edildi",
                    CustomerId = 1,
                }
           );
        }
    }
}
