namespace Booking.Models.Entities;

public class Employee : BaseEntity
{
    public string FullName { get; set; }
    public string PhotoUrl { get; set; }

    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue VenueNavigation { get; set; }

    [InverseProperty(nameof(EmployeeSchedule.EmployeeNavigation))]
    public IEnumerable<EmployeeSchedule> Schedules { get; set; } = new List<EmployeeSchedule>();
}
