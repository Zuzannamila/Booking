namespace Booking.Models.Entities.Owned;

public class Address
{
    public string Street { get; set; } = null!;
    public string Unit { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? Province { get; set; }
    public string Country { get; set; } = null!;
}
