using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JimmyHaridy_MVC_2016_05.Models
{
    public class ShopContext: DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public ShopContext() : base("ShopDB")
        {
            Database.SetInitializer<ShopContext>(new ShopInitializer());
        }

        public class ShopInitializer : DropCreateDatabaseAlways<ShopContext>
        {
            protected override void Seed(ShopContext context)
            {

                //var elgiganten = new Store() {StoreId = 1, Name = "Elgiganten", Address = "Södervägen 37, 265 35 Helsingborg "};
                //var siba = new Store() {StoreId = 1, Name = "Siba", Address = "Välavägen 25, 254 35 Helsingborg"};
                //var storeList = new List<Store>() {elgiganten, siba};
                var storeList = new List<Store>()
                {
                    new Store() {StoreId = 1, Name = "Elgiganten", Address = "Södervägen 37, 265 35 Helsingborg "},
                    new Store() {StoreId = 1, Name = "Siba", Address = "Välavägen 25, 254 35 Helsingborg"},
            };
                var productList = new List<Product>()
                {
                    new Product() {ProductId = 1, Name = "Iphone 6", Price = 6000, ProductNumber = "p-123",
                        ProductText = "Iphone 6s Black with great new functions in camera", ProductsinStock = 150, StoreId = 1},
                     new Product() {ProductId = 2, Name = "Samsung TV", Price = 15000, ProductNumber = "p-234",
                        ProductText = "New great Samsung Led TV with the latest functions", ProductsinStock = 58, StoreId = 1},
                     new Product() {ProductId = 3, Name = "Asus Computer", Price = 14500, ProductNumber = "p-345",
                        ProductText = "The latest computer with the greatest graphic card", ProductsinStock = 20, StoreId = 2},
                      new Product() {ProductId = 4, Name = "Camera 25X Samsung", Price = 5525, ProductNumber = "p-456",
                        ProductText = "New great camera with super zoom functions", ProductsinStock = 33, StoreId = 2},

                };
                foreach (var item in storeList)
                {
                    context.Stores.Add(item);
                }
                context.SaveChanges();
                foreach (var item in productList)
                {
                    context.Products.Add(item);
                }
                context.SaveChanges();
            }
        }
    }
}