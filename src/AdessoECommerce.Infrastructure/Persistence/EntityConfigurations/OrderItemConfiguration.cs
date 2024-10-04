using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("order_items").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        
        builder.Property(i => i.OrderId).HasColumnName("order_id").IsRequired(); // Foreign Key
        builder.Property(i => i.ProductId).HasColumnName("product_id").IsRequired(); // Foreign Key
        builder.Property(i => i.Quantity).HasColumnName("quantity").IsRequired();
        builder.Property(i => i.Price).HasColumnName("price").IsRequired();

        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
        builder.HasOne(i => i.Product).WithMany().HasForeignKey(i => i.ProductId);
        builder.HasOne(i => i.Order).WithMany(i => i.OrderItems).HasForeignKey(i => i.OrderId);
    }
}