using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopFa.Models;
using Microsoft.EntityFrameworkCore;

namespace eShopFa.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SellerProductPrice> SellerProductPrices { get; set; }
        public DbSet<BestPrice> BestPrices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SellerProductPrice>().HasKey(s => new { s.ProductId, s.SellerId });
            modelBuilder.Entity<BestPrice>().HasKey(b => new { b.ProductId, b.SellerId, b.CategoryId});

            base.OnModelCreating(modelBuilder);
        }
    }
}
