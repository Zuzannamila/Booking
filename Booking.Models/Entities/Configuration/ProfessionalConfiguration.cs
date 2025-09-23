namespace Booking.Models.Entities.Configuration;

public class ProfessionalConfiguration : IEntityTypeConfiguration<Professional>
{
    public void Configure(EntityTypeBuilder<Professional> builder)
    {
        builder.HasOne(e => e.VenueNavigation)
            .WithMany(v => v.Professionals)
            .HasForeignKey(e => e.VenueId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.OwnsMany(e => e.Schedules, s =>
        {
            s.ToTable("ProfessionalSchedules");
        });
    }
}
