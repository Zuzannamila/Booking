namespace Booking.Models.Entities.Owned;

[Owned]
public class VenuePhoto
{
    public string Url { get; set; } = null!;
    public string? Caption { get; set; }
    // SEO
    public string? AltText { get; set; }
    public int SortOrder { get; set; }
}
