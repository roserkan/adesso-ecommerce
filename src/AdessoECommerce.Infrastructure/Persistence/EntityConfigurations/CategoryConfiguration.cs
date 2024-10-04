using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();

        builder.Property(i => i.Name).HasColumnName("name").IsRequired();
        builder.Property(i => i.Description).HasColumnName("description").IsRequired();
        
        builder.Property(i => i.ParentCategoryId).HasColumnName("parent_category_id");
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
        builder.HasOne(i => i.ParentCategory)
            .WithMany(i => i.SubCategories)
            .HasForeignKey(i => i.ParentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}