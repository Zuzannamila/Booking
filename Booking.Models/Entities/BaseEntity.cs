namespace Booking.Models.Entities;

public class BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}
