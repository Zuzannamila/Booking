namespace Booking.Models.Entities;

[Table("ServiceCategories", Schema = "dbo")]
public class ServiceCategory
{
    public short Id { get; set; }
    public string Name { get; set; } = null!;
    [InverseProperty(nameof(ServiceSubCategory.CategoryNavigation))]
    public ICollection<ServiceSubCategory> SubCategories { get; set; } = new List<ServiceSubCategory>();
}

[Table("ServiceSubCategories", Schema = "dbo")]
public class ServiceSubCategory
{
    public short Id { get; set; }
    public string Name { get; set; } = null!;
    public short CategoryId { get; set; }
    [ForeignKey(nameof(ServiceSubCategory.CategoryId))]
    public ServiceCategory CategoryNavigation { get; set; } = null!;
}
