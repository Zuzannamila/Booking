namespace Booking.Models.Entities;

public class Employee : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string? PhotoUrl { get; set; }


    public Guid VenueId { get; set; }
    [ForeignKey(nameof(VenueId))]
    public Venue VenueNavigation { get; set; } = null!;

    public ICollection<EmployeeSchedule> Schedules { get; set; } = new List<EmployeeSchedule>();

    public bool IsDeleted { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public void SoftDelete()
    {
        IsDeleted = true;
        DeletedAt = DateTime.UtcNow;
    }
}
