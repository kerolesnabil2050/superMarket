using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    public class Context:DbContext
    {
        public DbSet<Stor> Stors { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
         public DbSet<Proudect> proudcts { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Recipt> recipts { get; set; }
        public DbSet<Sellinvoce> sellinvoces { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data source=DESKTOP-TOJ495J\SQL19; initial catalog = SuperMarket;Integrated Security=True; trust server certificate = true");
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Users
            modelBuilder.Entity<Users>().HasData(new[]
            {
                 new Users
                     {
                        Salary = 2000,
                        UserName = "Ahmed",
                        Password = 12345,
                        Pos = position.Casher
                     },
                 new Users
                     {
                        Salary = 1000,
                        UserName = "Mahmoud",
                        Password = 2555,
                        Pos = position.Casher
                     },
                 new Users
                 {
                     Salary = 3000,
                     UserName = "Nada",
                     Password = 54321,
                     Pos = position.Admin
                 }
            });
           

            //Suppliers
            modelBuilder.Entity<Suppliers>().HasData(new[]
            {
                new Suppliers
                {
                Id = 1,
                Name = "Manar",
                Phone = "01028574231",
                },
                new Suppliers
                {
                 Id = 2,
                Name = "Alaa",
                Phone = "01055688224",
                },
                new Suppliers
                {
                 Id = 3,
                Name = "Selevia",
                Phone = "0104567432",
                }
            });
           

            //Store
            modelBuilder.Entity<Stor>().HasData(new [] 
            {
                new Stor{
                     Id = 1,
                    Name = "Store1",
                    Location = "Assiut"
                },
               new Stor{
                      Id = 2,
                Name = "Store2",
                Location = "Alex"
                },
               new Stor{
                      Id = 3,
                Name = "Store3",
                Location = "Cairo"
                }

            });
           
            //Categories
            modelBuilder.Entity<Categorys>().HasData(new [] 
            {
                new Categorys
                {
                    Id = 1,
                    Name = "Dairy",
                    StorId = 1
                },
                new Categorys
                {
                     Id = 2,
                    Name = "Beverages",
                    StorId = 1
                },
                new Categorys
                {
                    Id = 3,
                   Name = "Vegetables",
                   StorId = 2
                },
                new Categorys
                {
                     Id = 4,
                Name = "Personal Care",
                StorId = 2,
                },
                new Categorys
                {
                    Id = 5,
                Name = "Meat",
                StorId = 2,
                },
                new Categorys
                {
                    Id = 6,
                Name = "Pasta/Rice",
                StorId = 3,
                },
                new Categorys
                {
                    Id = 7,
                Name = "Fruits",
                StorId = 3,
                }

            });
            //Products
            modelBuilder.Entity<Proudect>().HasData(new [] 
            {
                new Proudect
                {
                     Id = 1,
                    Name = "Milk",
                    SellingPrice = 15,
                    PurchasingPrice = 11,
                    Quantity = 20,
                    ProductionDate = new DateTime(2023, 2, 17),
                    ExpirationDate = new DateTime(2023, 3, 1),
                    CategorysId= 1,
                    Suppliersid=1
                },
                new Proudect
                {
                     Id = 2,
                    Name = "Cheese",
                    SellingPrice = 30,
                    PurchasingPrice = 25,
                    Quantity = 17,
                    ProductionDate = new DateTime(2023, 5, 2),
                    ExpirationDate = new DateTime(2023, 3, 7),
                    CategorysId = 1,
                    Suppliersid = 1
                },
                new Proudect
                {
                       Id = 3,
                    Name = "Egg",
                    SellingPrice = 5,
                    PurchasingPrice = 3,
                    Quantity = 200,
                    ProductionDate = new DateTime(2023, 1, 1),
                    ExpirationDate = new DateTime(2023, 2, 1),
                    CategorysId = 1,
                    Suppliersid = 1
                },
                new Proudect
                {
                     Id = 4,
                    Name = "Water",
                    SellingPrice = 6,
                    PurchasingPrice = 4,
                    Quantity = 25,
                    ProductionDate = new DateTime(2023, 1, 12),
                    ExpirationDate = new DateTime(2023, 2, 2),
                    CategorysId = 2,
                    Suppliersid = 2
                },
                new Proudect
                {
                     Id = 5,
                    Name = "Coffee",
                    SellingPrice = 10,
                    PurchasingPrice = 7,
                    Quantity = 48,
                    ProductionDate = new DateTime(2023, 11, 11),
                    ExpirationDate = new DateTime(2023, 5, 1),
                    CategorysId = 2,
                    Suppliersid = 2
                },
                new Proudect
                {
                      Id = 6,
                    Name = "Juice",
                    SellingPrice = 16,
                    PurchasingPrice = 12,
                    Quantity = 36,
                    ProductionDate = new DateTime(2023, 11, 4),
                    ExpirationDate = new DateTime(2023, 6, 4),
                    CategorysId = 2,
                    Suppliersid = 2
                },
                new Proudect
                {
                     Id = 7,
                    Name = "Tomato",
                    SellingPrice = 6,
                    PurchasingPrice = 5,
                    Quantity = 70,
                    ProductionDate = new DateTime(2023, 10, 5),
                    ExpirationDate = new DateTime(2023, 2, 2),
                    CategorysId = 3,
                    Suppliersid = 3
                },
                new Proudect
                {
                      Id = 8,
                    Name = "Potato",
                    SellingPrice = 14,
                    PurchasingPrice = 12,
                    Quantity = 36,
                    ProductionDate = new DateTime(2023, 9, 4),
                    ExpirationDate = new DateTime(2023, 5, 3),
                    CategorysId = 3,
                    Suppliersid = 3
                },
                new Proudect
                {
                      Id = 9,
                    Name = "cucumber",
                    SellingPrice = 17,
                    PurchasingPrice = 15,
                    Quantity = 25,
                    ProductionDate = new DateTime(2023, 7, 6),
                    ExpirationDate = new DateTime(2023, 10, 7),
                    CategorysId = 3,
                    Suppliersid = 3
                },
            });

        }
    }
}
