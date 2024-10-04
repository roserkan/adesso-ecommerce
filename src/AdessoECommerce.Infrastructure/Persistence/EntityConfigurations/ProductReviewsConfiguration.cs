using AdessoECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoECommerce.Infrastructure.Persistence.EntityConfigurations;

public class ProductReviewConfiguration : IEntityTypeConfiguration<ProductReviews>
{
    public void Configure(EntityTypeBuilder<ProductReviews> builder)
    {
        builder.ToTable("product_reviews").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id").IsRequired();

        builder.Property(i => i.CustomerId).HasColumnName("customer_id").IsRequired(); // FK
        builder.Property(i => i.ProductId).HasColumnName("product_id").IsRequired(); // FK
        builder.Property(i => i.Rating).HasColumnName("rating").IsRequired();
        builder.Property(i => i.Comment).HasColumnName("comment").IsRequired();
        
        builder.Property(i => i.CreatedDate).HasColumnName("created_date");
        builder.Property(i => i.UpdatedDate).HasColumnName("updated_date");
        
        builder.HasOne(i => i.Customer).WithMany().HasForeignKey(i => i.CustomerId);
        builder.HasOne(i => i.Product).WithMany().HasForeignKey(i => i.ProductId);
    }
}