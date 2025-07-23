namespace Booking.Models.Entities.Configuration;

public class VisitConfiguration : IEntityTypeConfiguration<Visit>
{
    public void Configure(EntityTypeBuilder<Visit> builder)
    {
        builder.HasOne(b => b.VenueNavigation)
            .WithMany()
            .HasForeignKey(b => b.VenueId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(b => b.ServiceNavigation)
            .WithMany()
            .HasForeignKey(b => b.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(b => b.EmployeeNavigation)
            .WithMany()
            .HasForeignKey(b => b.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(b => b.ClientNavigation)
            .WithMany()
            .HasForeignKey(b => b.ClientId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
