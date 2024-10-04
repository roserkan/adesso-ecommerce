using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("payments").HasKey(i => i.Id);
        
        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        
        builder.Property(i => i.OrderId).HasColumnName("order_id").IsRequired(); // DK
        builder.Property(i => i.Amount).HasColumnName("amount").IsRequired();
        builder.Property(i => i.Status).HasColumnName("status").IsRequired();
        builder.Property(i => i.PaymentMethod).HasColumnName("payment_method").IsRequired();
        builder.Property(i => i.PaymentDate).HasColumnName("payment_date").IsRequired();
        builder.Property(i => i.TransactionId).HasColumnName("transaction_id").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
    }
}