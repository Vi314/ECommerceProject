using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace NetEcommerce.DAL.Context
{
    public class ProjectContext : IdentityDbContext<AppUser, AppUserRole, int>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }



        //FakeData
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser




            //Suppliers
            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier
                {
                    Id=1,
                    CompanyName="Amazon",
                    ContactTitle="ContactTitle",
                    ContactNumber="420420420",
                    Address="Streets of Los Angeles",
                    City="Probably los angeles",
                    Region="Might be los angeles",
                    PostalCode="420420",
                    Country="Hollywood",
                    Status=NetECommerce.Entity.Enum.Status.Inserted
                },
                new Supplier
                {
                    Id=2,
                    CompanyName="Tesla",
                    ContactTitle="ContactTitle",
                    ContactNumber="420420420",
                    Address="Not The Streets of Los Angeles",
                    City="Probably not los angeles",
                    Region="Might not be los angeles",
                    PostalCode="420420",
                    Country="Bollywood",
                    Status=NetECommerce.Entity.Enum.Status.Inserted
                }
            };
            builder.Entity<Supplier>().HasData(suppliers);

            //Categories
            List<Category> categories = new List<Category>
           {
               new Category
               {
                   Id=1,
                   CategoryName="Teknoloji",
                   Description="teknolojik ürünler",
                   Status=NetECommerce.Entity.Enum.Status.Inserted
               },
               new Category
               {
                   Id=2,
                   CategoryName="Giyim",
                   Description="yazlık kışlık giyim ürünleri",
                   Status=NetECommerce.Entity.Enum.Status.Inserted
               }
           };
            builder.Entity<Category>().HasData(categories);

            //Products
            List<Product> products = new List<Product>()
            {
                new Product {
                    Id=1,
                    ProductName="MSI",
                    UnitPrice=20000,
                    UnitsInStock=50,
                    CategoryId=categories.Where(x=>x.CategoryName=="Teknoloji").FirstOrDefault().Id,
                    Status=NetECommerce.Entity.Enum.Status.Inserted,
                    SupplierId=1
                },
                new Product {
                    Id=2,
                    ProductName="Nike Ayakkabı",
                    UnitPrice=2000,
                    UnitsInStock=150,
                    CategoryId=categories.Where(x=>x.CategoryName=="Giyim").FirstOrDefault().Id,
                    Status = NetECommerce.Entity.Enum.Status.Inserted,
                    SupplierId=2
                }
            };
            builder.Entity<Product>().HasData(products);

            //Orders
            List<Order> orders = new List<Order>
            {
                new Order
                {
                    Id=1,
                    Status = NetECommerce.Entity.Enum.Status.Inserted,
                    OrderStatus = NetECommerce.Entity.Enum.OrderStatus.Created,
                    OrderPrice = 450,
                    CustomerId = "5",
                    CustomerName = "Ezekiel"
                },
                new Order
                {
                    Id=2,
                    Status = NetECommerce.Entity.Enum.Status.Inserted,
                    OrderStatus = NetECommerce.Entity.Enum.OrderStatus.Created,
                    OrderPrice = 90,
                    CustomerId = "3",
                    CustomerName = "Michelangelo"
                }
            };
            builder.Entity<Order>().HasData(orders);

            //OrderDetails
            builder.Entity<OrderDetails>().HasKey(x => new { x.OrderId, x.ProductId });

            base.OnModelCreating(builder);
        }

    }
}
