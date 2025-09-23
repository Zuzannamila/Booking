namespace Booking.Models.Entities;

[Table("Venues", Schema = "dbo")]
public class Venue : BaseEntity
{
    public string Name { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Address AddressInformation { get; set; } = new Address();
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    [InverseProperty(nameof(Professional.VenueNavigation))]
    public virtual ICollection<Professional> Professionals { get; set; } = new List<Professional>();
    public virtual ICollection<OpeningHours> OpeningHours { get; set; } = new List<OpeningHours>();
}
