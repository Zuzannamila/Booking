namespace Booking.Models.Entities.Configuration;

public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.OwnsOne(v => v.AddressInformation, a =>
        {
            a.ToTable("Adresses");
        });

        builder.OwnsMany(v => v.VenuePhotos, p =>
        {
            p.ToTable("Photos");
        });

        builder.HasQueryFilter(v => !v.IsDeleted);
    }
}
