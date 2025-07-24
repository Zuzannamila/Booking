namespace Booking.Models.Entities.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.PhotoUrl)
            .HasMaxLength(512);

        builder.HasOne(e => e.VenueNavigation)
            .WithMany(v => v.Employees)
            .HasForeignKey(e => e.VenueId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.OwnsMany(e => e.Schedules, s =>
        {
            s.ToTable("EmployeeSchedules");
        });
    }
}
