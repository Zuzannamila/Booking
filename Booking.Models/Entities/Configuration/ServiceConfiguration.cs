namespace Booking.Models.Entities.Configuration;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasOne(s => s.VenueNavigation)
            .WithMany(v => v.Services)
            .HasForeignKey(s => s.VenueId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        builder.HasQueryFilter(s => !s.IsDeleted);
    }
}
