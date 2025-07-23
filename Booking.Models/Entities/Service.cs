namespace Booking.Models.Entities;

public class Service : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Category { get; set; }
    public decimal Price { get; set; }
    public TimeSpan Duration { get; set; }

    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue VenueNavigation { get; set; } = null!;

    public bool IsDeleted { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public void SoftDelete()
    {
        IsDeleted = true;
        DeletedAt = DateTime.UtcNow;
    }
}
