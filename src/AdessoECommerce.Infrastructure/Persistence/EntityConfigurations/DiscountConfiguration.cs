using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("discounts").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();

        builder.Property(i => i.Name).HasColumnName("name").IsRequired();
        builder.Property(i => i.Amount).HasColumnName("amount");
        builder.Property(i => i.Percentage).HasColumnName("percentage");
        builder.Property(i => i.StartDate).HasColumnName("start_date").IsRequired();
        builder.Property(i => i.EndDate).HasColumnName("end_date").IsRequired();
        builder.Property(i => i.DiscountType).HasColumnName("discount_type").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
    }
}