using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Infrastructure.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var seedProduct = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Title = "Laptop", ProductCode = "LAP123", Description = "High performance laptop", Price = 1200.99m, Stock = 10 },
            new Product { Id = Guid.NewGuid(), Title = "Smartphone", ProductCode = "SMP456", Description = "Latest model smartphone", Price = 899.99m, Stock = 25 },
            new Product { Id = Guid.NewGuid(), Title = "Headphones", ProductCode = "HDP789", Description = "Noise cancelling headphones", Price = 199.99m, Stock = 50 },
            new Product { Id = Guid.NewGuid(), Title = "Smartwatch", ProductCode = "SMW012", Description = "Smartwatch with health tracking", Price = 299.99m, Stock = 15 },
            new Product { Id = Guid.NewGuid(), Title = "Tablet", ProductCode = "TAB345", Description = "High resolution tablet", Price = 499.99m, Stock = 20 },
            new Product { Id = Guid.NewGuid(), Title = "Bluetooth Speaker", ProductCode = "BSP678", Description = "Portable Bluetooth speaker", Price = 89.99m, Stock = 40 },
            new Product { Id = Guid.NewGuid(), Title = "Camera", ProductCode = "CAM901", Description = "Digital SLR camera", Price = 799.99m, Stock = 8 },
            new Product { Id = Guid.NewGuid(), Title = "Gaming Console", ProductCode = "GMC234", Description = "Next-gen gaming console", Price = 499.99m, Stock = 12 },
            new Product { Id = Guid.NewGuid(), Title = "Electric Kettle", ProductCode = "EKT567", Description = "Fast boiling electric kettle", Price = 39.99m, Stock = 60 },
            new Product { Id = Guid.NewGuid(), Title = "Microwave Oven", ProductCode = "MWO890", Description = "Compact microwave oven", Price = 129.99m, Stock = 22 },
            new Product { Id = Guid.NewGuid(), Title = "Blender", ProductCode = "BLD123", Description = "High-speed blender", Price = 59.99m, Stock = 35 },
            new Product { Id = Guid.NewGuid(), Title = "Coffee Maker", ProductCode = "CFM456", Description = "Automatic coffee maker", Price = 79.99m, Stock = 18 },
            new Product { Id = Guid.NewGuid(), Title = "Refrigerator", ProductCode = "RFR789", Description = "Double door refrigerator", Price = 1099.99m, Stock = 5 },
            new Product { Id = Guid.NewGuid(), Title = "Washing Machine", ProductCode = "WSM012", Description = "Front load washing machine", Price = 699.99m, Stock = 7 },
            new Product { Id = Guid.NewGuid(), Title = "Air Conditioner", ProductCode = "ACD345", Description = "Energy efficient air conditioner", Price = 499.99m, Stock = 9 },
            new Product { Id = Guid.NewGuid(), Title = "Vacuum Cleaner", ProductCode = "VAC678", Description = "Cordless vacuum cleaner", Price = 149.99m, Stock = 30 },
            new Product { Id = Guid.NewGuid(), Title = "Television", ProductCode = "TVN901", Description = "4K Ultra HD television", Price = 799.99m, Stock = 14 },
            new Product { Id = Guid.NewGuid(), Title = "Soundbar", ProductCode = "SBR234", Description = "Dolby Atmos soundbar", Price = 299.99m, Stock = 21 },
            new Product { Id = Guid.NewGuid(), Title = "Router", ProductCode = "RTR567", Description = "High-speed WiFi router", Price = 99.99m, Stock = 45 },
            new Product { Id = Guid.NewGuid(), Title = "External Hard Drive", ProductCode = "EHD890", Description = "1TB external hard drive", Price = 59.99m, Stock = 28 },
            new Product { Id = Guid.NewGuid(), Title = "Monitor", ProductCode = "MNT123", Description = "24-inch full HD monitor", Price = 149.99m, Stock = 16 },
            new Product { Id = Guid.NewGuid(), Title = "Keyboard", ProductCode = "KYB456", Description = "Mechanical keyboard", Price = 79.99m, Stock = 25 },
            new Product { Id = Guid.NewGuid(), Title = "Mouse", ProductCode = "MSE789", Description = "Wireless mouse", Price = 29.99m, Stock = 40 },
            new Product { Id = Guid.NewGuid(), Title = "Printer", ProductCode = "PRT012", Description = "All-in-one printer", Price = 199.99m, Stock = 13 },
            new Product { Id = Guid.NewGuid(), Title = "Scanner", ProductCode = "SCN345", Description = "High-speed document scanner", Price = 99.99m, Stock = 10 },
            new Product { Id = Guid.NewGuid(), Title = "Webcam", ProductCode = "WBC678", Description = "HD webcam", Price = 49.99m, Stock = 27 },
            new Product { Id = Guid.NewGuid(), Title = "Fitness Tracker", ProductCode = "FTR901", Description = "Activity and sleep tracker", Price = 99.99m, Stock = 32 },
            new Product { Id = Guid.NewGuid(), Title = "Electric Toothbrush", ProductCode = "ETB234", Description = "Rechargeable electric toothbrush", Price = 69.99m, Stock = 23 },
            new Product { Id = Guid.NewGuid(), Title = "Hair Dryer", ProductCode = "HDR567", Description = "Professional hair dryer", Price = 59.99m, Stock = 20 },
            new Product { Id = Guid.NewGuid(), Title = "Espresso Machine", ProductCode = "ESM890", Description = "Automatic espresso machine", Price = 399.99m, Stock = 11 }
        };
            builder.HasData(seedProduct);
        }
    }
}

