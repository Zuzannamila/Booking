namespace Booking.Models.Entities;

public class Venue : BaseEntity
{
    public string Name { get; set; } = null!;
    public Address AddressInformation { get; set; } = new Address();
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    [InverseProperty(nameof(Service.VenueNavigation))]
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    [InverseProperty(nameof(Employee.VenueNavigation))]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<VenuePhoto> VenuePhotos { get; set; } = new List<VenuePhoto>();
    public virtual ICollection<OpeningHours> OpeningHours { get; set; } = new List<OpeningHours>();

    public bool IsDeleted { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public void SoftDelete()
    {
        IsDeleted = true;
        DeletedAt = DateTime.UtcNow;
    }
}
