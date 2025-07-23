namespace Booking.Models.Entities.Configuration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(c => c.Email)
            .HasMaxLength(320);
        builder.HasIndex(c => c.Email)
            .IsUnique();
    }
}
