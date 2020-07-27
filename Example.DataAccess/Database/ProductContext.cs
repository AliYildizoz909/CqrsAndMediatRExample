using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess.Database
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(product => product.Id);
        }
    }
}
