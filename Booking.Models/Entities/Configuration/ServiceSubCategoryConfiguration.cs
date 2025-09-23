namespace Booking.Models.Entities.Configuration;

public class ServiceSubCategoryConfiguration : IEntityTypeConfiguration<ServiceSubCategory>
{
    public void Configure(EntityTypeBuilder<ServiceSubCategory> builder)
    {
        builder.Property(sc => sc.Name)
            .HasMaxLength(100);
        builder.Property(sc => sc.Id)
            .ValueGeneratedNever();
        builder.HasOne(sc => sc.CategoryNavigation)
            .WithMany(c => c.SubCategories)
            .HasForeignKey(sc => sc.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
