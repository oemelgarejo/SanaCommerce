using System;
using Microsoft.EntityFrameworkCore;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);

            modelBuilder.Entity<OrderItem>()
                .HasKey(op => new { op.OrderId, op.ProductId });

            modelBuilder.Entity<OrderItem>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(op => op.ProductId);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }


}

