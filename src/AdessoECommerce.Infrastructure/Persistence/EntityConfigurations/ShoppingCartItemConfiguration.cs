using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class ShoppingCartItemConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
{
    public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
    {
        builder.ToTable("shopping_cart_items").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();

        builder.Property(i => i.ShoppingCartId).HasColumnName("shopping_cart_id").IsRequired(); // FK
        builder.Property(i => i.ProductId).HasColumnName("product_id").IsRequired(); // FK
        builder.Property(i => i.Quantity).HasColumnName("quantity").IsRequired();
        builder.Property(i => i.Price).HasColumnName("price").IsRequired();
    }
}