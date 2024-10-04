using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("orders").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        
        builder.Property(i => i.CustomerId).HasColumnName("customer_id").IsRequired(); // FK
        builder.Property(i => i.AddressId).HasColumnName("address_id").IsRequired(); // FK
        builder.Property(i => i.OrderNumber).HasColumnName("order_number").IsRequired();
        builder.Property(i => i.TotalPrice).HasColumnName("total_price").IsRequired();
        builder.Property(i => i.DiscountedTotalPrice).HasColumnName("discounted_total_price").IsRequired();
        builder.Property(i => i.Status).HasColumnName("status").IsRequired();
        builder.Property(i => i.PaymentMethod).HasColumnName("payment_method").IsRequired();
        builder.Property(i => i.OrderDate).HasColumnName("order_date").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
    }
}