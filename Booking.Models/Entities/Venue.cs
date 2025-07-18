namespace Booking.Models.Entities;

[Table("Venues", Schema = "dbo")]
public class Venue : BaseEntity
{
    public string Name { get; set; }
    public string About { get; set; }
    public Address AddressInformation { get; set; } = new Address();
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public virtual IEnumerable<Service> Services { get; set; } = new List<Service>();
    public virtual IEnumerable<Employee> Emplye { get; set; } = new List<Employee>();
    public virtual IEnumerable<VenuePhoto> VenuePhotos { get; set; } = new List<VenuePhoto>();
    public virtual IEnumerable<OpeningHours> OpeningHours { get; set; } = new List<OpeningHours>();
}
