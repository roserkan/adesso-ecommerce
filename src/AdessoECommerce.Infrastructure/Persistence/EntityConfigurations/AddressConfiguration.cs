using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();
        
        builder.Property(i => i.CustomerId).HasColumnName("customer_id").IsRequired(); // FK
        builder.Property(i => i.Title).HasColumnName("title").IsRequired();
        builder.Property(i => i.AddressLine).HasColumnName("address_line").IsRequired();
        builder.Property(i => i.City).HasColumnName("city").IsRequired();
        builder.Property(i => i.District).HasColumnName("district").IsRequired();
        builder.Property(i => i.PhoneNumber).HasColumnName("phone_number").IsRequired();
        builder.Property(i => i.Description).HasColumnName("description");
        builder.Property(i => i.IsDefault).HasColumnName("is_default").IsRequired();
        
    
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
    }
}