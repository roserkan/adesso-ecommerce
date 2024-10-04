using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
{
    public void Configure(EntityTypeBuilder<ProductAttribute> builder)
    {
        builder.ToTable("product_attributes").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        
        builder.Property(i => i.ProductId).HasColumnName("product_id").IsRequired(); // FK
        builder.Property(i => i.AttributeId).HasColumnName("attribute_id").IsRequired(); // FK
        builder.Property(i => i.Value).HasColumnName("value").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
        builder.HasOne(i => i.Product).WithMany(i => i.ProductAttributes).HasForeignKey(i => i.ProductId);
        builder.HasOne(i => i.Attribute).WithMany(i => i.ProductAttributes).HasForeignKey(i => i.AttributeId);
    }
}