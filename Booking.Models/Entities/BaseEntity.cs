namespace Booking.Models.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    [Timestamp]
    public byte[] Timestamp { get; set; } = null!;
}
