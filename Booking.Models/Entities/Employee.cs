namespace Booking.Models.Entities;

[Table("Employees", Schema = "dbo")]
public class Employee : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string? PhotoUrl { get; set; }


    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue VenueNavigation { get; set; } = null!;

    public ICollection<EmployeeSchedule> Schedules { get; set; } = new List<EmployeeSchedule>();
}
