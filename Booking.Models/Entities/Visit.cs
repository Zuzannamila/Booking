namespace Booking.Models.Entities;

[Table("Visits", Schema = "dbo")]
public class Visit : BaseEntity
{
    public Guid ServiceId { get; set; }
    public string ServiceNameSnapshot { get; set; } = null!;

    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public virtual Venue VenueNavigation { get; set; } = null!;
    public Guid? ProfessionalId { get; set; }
    [ForeignKey(nameof(ProfessionalId))]
    public virtual Professional? ProfessionalNavigation { get; set; } 

    public Guid ClientId { get; set; }
    [ForeignKey(nameof(ClientId))]
    public virtual Client ClientNavigation { get; set; } = null!;

    public DateTimeOffset Start { get; set; }
    public DateTimeOffset End { get; set; }
    public VisitStatus Status { get; set; } = VisitStatus.Pending;
}
