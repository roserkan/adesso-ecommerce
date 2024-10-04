using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customers").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();

        builder.Property(i => i.FirstName).HasColumnName("first_name").IsRequired();
        builder.Property(i => i.LastName).HasColumnName("last_name").IsRequired();
        builder.Property(i => i.PasswordHash).HasColumnName("password_hash").IsRequired();
        builder.Property(i => i.PasswordSalt).HasColumnName("password_salt").IsRequired();
    
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
        builder.HasIndex(i => i.EmailAddress).IsUnique();
    }
}