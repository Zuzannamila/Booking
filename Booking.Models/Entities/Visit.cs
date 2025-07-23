namespace Booking.Models.Entities;

public class Visit : BaseEntity
{
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset End { get; set; }
    public VisitStatus Status { get; set; } = VisitStatus.Pending;

    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public virtual Venue VenueNavigation { get; set; } = null!;

    public Guid ServiceId { get; set; }
    [ForeignKey(nameof(ServiceId))]
    public virtual Service ServiceNavigation { get; set; } = null!;

    public Guid? EmployeeId { get; set; }
    [ForeignKey(nameof(EmployeeId))]
    public virtual Employee? EmployeeNavigation { get; set; } 

    public Guid ClientId { get; set; }
    [ForeignKey(nameof(ClientId))]
    public virtual Client ClientNavigation { get; set; } = null!;
}
