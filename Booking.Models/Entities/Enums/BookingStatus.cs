namespace Booking.Models.Entities.Enums;

public enum BookingStatus : byte
{
    Pending = 0,
    Confirmed = 1,
    Cancelled = 2,
    Rescheduled = 3,
}
