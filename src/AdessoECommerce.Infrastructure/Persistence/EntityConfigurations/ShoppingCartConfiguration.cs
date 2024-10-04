using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
{
    public void Configure(EntityTypeBuilder<ShoppingCart> builder)
    {
        builder.ToTable("shopping_carts").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        builder.Property(i => i.CustomerId).HasColumnName("customer_id").IsRequired(); // FK
        builder.Property(i => i.TotalPrice).HasColumnName("total_price").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
    }
}