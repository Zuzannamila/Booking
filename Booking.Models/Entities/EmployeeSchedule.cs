namespace Booking.Models.Entities;

public class EmployeeSchedule : BaseEntity
{
    public OpeningHours Availability { get; set; }

    public Guid EmployeeId { get; set; }
    [ForeignKey(nameof(EmployeeId))]
    public Employee EmployeeNavigation { get; set; }
}
