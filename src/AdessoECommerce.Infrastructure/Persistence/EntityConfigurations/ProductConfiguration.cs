using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        
        builder.Property(i => i.BrandId).HasColumnName("brand_id").IsRequired(); // Foreign Key
        builder.Property(i => i.CategoryId).HasColumnName("category_id").IsRequired(); // Foreign Key
        builder.Property(i => i.Name).HasColumnName("name").IsRequired();
        builder.Property(i => i.Description).HasColumnName("description").IsRequired();
        builder.Property(i => i.Price).HasColumnName("price").IsRequired();
        builder.Property(i => i.StockQuantity).HasColumnName("stock_quantity").IsRequired();
        builder.Property(i => i.Status).HasColumnName("status").IsRequired();
    
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
    }
}