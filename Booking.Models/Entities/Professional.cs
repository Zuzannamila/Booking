namespace Booking.Models.Entities;

[Table("Professionals", Schema = "dbo")]
public class Professional : BaseEntity
{
    public string FullName { get; set; } = null!;
    public Guid? VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue? VenueNavigation { get; set; } = null!;

    public ICollection<OpeningHours> Schedules { get; set; } = new List<OpeningHours>();
}
