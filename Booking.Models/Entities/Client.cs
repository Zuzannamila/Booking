namespace Booking.Models.Entities;

[Table("Clients", Schema = "dbo")]
[Index(nameof(Email), IsUnique = true)]
public class Client : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string Email { get; set; } = null!;
}
