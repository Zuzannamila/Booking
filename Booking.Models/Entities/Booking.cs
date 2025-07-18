using Booking.Models.Entities.Enums;

namespace Booking.Models.Entities;

public class Booking : BaseEntity
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public BookingStatusEnum Status { get; set; } = BookingStatusEnum.Pending;

    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue VenueNavigation { get; set; }

    public Guid ServiceId { get; set; }
    [ForeignKey(nameof(ServiceId))]
    public Service ServiceNavigation { get; set; }

    public Guid EmployeeId { get; set; }
    [ForeignKey(nameof(EmployeeId))]
    public Employee EmployeeNavigation { get; set; }

    public Guid ClientId { get; set; }
    [ForeignKey(nameof(ClientId))]
    public Client ClientNavigation { get; set; }
}
