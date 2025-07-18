namespace Booking.Models.Entities;

public class Service : BaseEntity
{
    [Required]
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public TimeSpan Duration { get; set; }

    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue VenueNavigation { get; set; }
}
