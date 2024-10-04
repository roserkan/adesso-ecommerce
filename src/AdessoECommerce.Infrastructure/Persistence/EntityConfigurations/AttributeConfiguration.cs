using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Attribute = AdessoECommerce.Domain.Entities.Attribute;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class AttributeConfiguration : IEntityTypeConfiguration<Attribute>
{
    public void Configure(EntityTypeBuilder<Attribute> builder)
    {
        builder.ToTable("attributes").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();

        builder.Property(i => i.Name).HasColumnName("name").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
    }
}