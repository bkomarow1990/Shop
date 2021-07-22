using DAL.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.EF
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext()
            : base("name=ShopDBContext")
        {
            Database.SetInitializer(new ShopDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().Property(w => w.PhoneNumber).HasMaxLength(12);
            base.OnModelCreating(modelBuilder);
        }

         public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<City> Cities { get; set; }
         public virtual DbSet<Country> Countries { get; set; }
         public virtual DbSet<Position> Positions { get; set; }
         public virtual DbSet<Product> Products { get; set; }
         public virtual DbSet<Shop> Shops { get; set; }
         public virtual DbSet<Worker> Workers { get; set; }
    }






}