namespace Booking.Models.Entities.Configuration;

public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
{
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
        builder.Property(p => p.BlobKey)
            .HasMaxLength(320);
    }
}
