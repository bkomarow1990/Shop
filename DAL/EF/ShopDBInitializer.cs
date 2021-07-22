using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.EF
{
    class ShopDBInitializer : DropCreateDatabaseAlways<ShopDBContext>
    {
        protected override void Seed(ShopDBContext context)
        {
            base.Seed(context);

            Country Ukraine = context.Countries.Add(new Country { Name = "Ukraine"});
            Country Poland = context.Countries.Add(new Country { Name = "Poland"});
            Country USA = context.Countries.Add(new Country { Name = "USA"});
            Country Belarus = context.Countries.Add(new Country { Name = "Belarus"});
            Country Czech = context.Countries.Add(new Country { Name = "Czech"});
            context.SaveChanges();

            City Zdolbuniv = context.Cities.Add(new City { Name = "Zdolbuniv", Country = Ukraine});
            City Rivne = context.Cities.Add(new City { Name = "Rivne", Country = Ukraine});
            City Kiew = context.Cities.Add(new City { Name = "Kiew", Country = Ukraine});
            City Lwiw = context.Cities.Add(new City { Name = "Lwiw", Country = Ukraine});
            City NewYork = context.Cities.Add(new City { Name = "New-York", Country = USA});
            City Minsk = context.Cities.Add(new City { Name = "Minsk", Country = USA});
            City Prague = context.Cities.Add(new City { Name = "Prague", Country = Czech});
            context.SaveChanges();

            Shop Shop23_7 = context.Shops.Add(new Shop { Name = "23-7", Adress = "Soborna 22A", City = Rivne});
            context.SaveChanges();

            Category MeatCategory = context.Categories.Add(new Category { Name = "Meat"}); 
            Category BreadCategory = context.Categories.Add(new Category { Name = "Bread"}); 
            Category AlcoholCategory = context.Categories.Add(new Category { Name = "Alcohol"}); 
            Category Shoes = context.Categories.Add(new Category { Name = "Shoes"});
            context.SaveChanges();

            Position AdministratorPosition = context.Positions.Add(new Position { Name = "Administrator" });
            Position SellerPosition = context.Positions.Add(new Position { Name = "Seller" });
            Position CleanerPosition = context.Positions.Add(new Position { Name = "Cleaner" });
            context.SaveChanges();

            Product Piwas = context.Products.Add(new Product { Name = "Piwas", Category = AlcoholCategory, Discount = 228, Price = 12, IsInStock = false, Quantity = 1337, Shops = new HashSet<Shop> { Shop23_7} });
            context.SaveChanges();

        }
    }
}
