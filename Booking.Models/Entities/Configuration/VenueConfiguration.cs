namespace Booking.Models.Entities.Configuration;

public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        int order = 80;
        builder.OwnsOne(v => v.AddressInformation, 
            ad =>
            {
                ad.Property<string>(nameof(Address.Street))
                    .HasColumnName("Street")
                    .HasColumnOrder(order);
                ad.Property<string>(nameof(Address.Unit))
                    .HasColumnName("Unit")
                    .HasColumnOrder(order + 1);
                ad.Property(nameof(Address.City))
                    .HasColumnName("City")
                    .HasColumnOrder(order + 2);
                ad.Property(nameof(Address.PostalCode))
                   .HasColumnName("PostCode")
                   .HasColumnOrder(order + 3);
                ad.Property(nameof(Address.Province))
                   .HasColumnName("Province")
                   .HasColumnOrder(order + 4);
                ad.Property(nameof(Address.Country))
                   .HasColumnName("Country")
                   .HasColumnOrder(order + 5);
            });
        builder.OwnsMany(v => v.Services, s =>
        {
            s.Property(x => x.Name)
                .HasMaxLength(200);
            s.Property<decimal>(nameof(Service.Price))
                .HasColumnType("decimal(18,2)");
            s.HasOne(x => x.CategoryNavigation)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            s.HasOne(x => x.SubCategoryNavigation)
                .WithMany()
                .HasForeignKey(x => x.SubCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            s.ToTable("VenueServices");
        });
        builder.OwnsMany(v => v.OpeningHours, oh =>
        {
            oh.ToTable("VenueOpeningHours");
        });
    }
}
