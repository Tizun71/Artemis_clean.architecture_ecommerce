using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "Nike Blazer Phantom Low",
                    ProductDescription = "Blazer Phantom tái hiện hình dáng cổ điển với kiểu dáng đẹp, thấp.",
                    Price = 3369000,
                    ImageUrl = "",
                    IsAvailable = true,
                    StockQuantity = 3,
                    CategoryID = 1,
                }    
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Giày thường ngày",
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Giày thể thao"
                }
            );
        }
    }
}
