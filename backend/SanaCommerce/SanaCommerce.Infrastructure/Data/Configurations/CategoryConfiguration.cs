using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanaCommerce.Domain.Entities;

namespace SanaCommerce.Infrastructure.Data.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("bdb2d6e1-8c5e-4b28-8ed8-53c8b57a17f3"),
                Name = "Electronics"
            },
            new Category
            {
                Id = Guid.Parse("5a0f889b-5e91-4d83-bb0e-0d6823d3d292"),
                Name = "Clothing"
            },
            new Category
            {
                Id = Guid.Parse("1291e60e-dde0-4c8b-b622-2b394cfc44e5"),
                Name = "Home"
            },
            new Category
            {
                Id = Guid.Parse("1f31e90d-faa1-4eae-b54d-3c33aafc2896"),
                Name = "Books"
            },
            new Category
            {
                Id = Guid.Parse("d75e74ff-77ee-4486-9916-1c842e36a6c7"),
                Name = "Toys"
            });
        }
    }
}

