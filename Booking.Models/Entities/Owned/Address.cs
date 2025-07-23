namespace Booking.Models.Entities.Owned;

[Owned]
public class Address
{
    public string Street { get; set; } = null!;
    public int Unit { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? StateOrProvince { get; set; }
    public string Country { get; set; } = null!;
}
