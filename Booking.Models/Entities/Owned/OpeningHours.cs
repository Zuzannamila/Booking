namespace Booking.Models.Entities.Owned;

public class OpeningHours
{
    public DayOfWeek Day { get; set; }
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }
}
