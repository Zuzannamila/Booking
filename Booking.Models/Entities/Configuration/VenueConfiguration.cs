namespace Booking.Models.Entities.Configuration;

public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.OwnsOne(v => v.AddressInformation);

        builder.OwnsMany(v => v.VenuePhotos, p =>
        {
            p.ToTable("Photos");
        });
        builder.OwnsMany(v => v.OpeningHours, p =>
        {
            p.ToTable("OpeningHours");
        });
    }
}
