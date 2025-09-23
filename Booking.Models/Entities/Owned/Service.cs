namespace Booking.Models.Entities.Owned;

public class Service 
{
    public string Name { get; set; } = null!;
    public short? CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public ServiceCategory? CategoryNavigation { get; set; }
    public short? SubCategoryId { get; set; }
    [ForeignKey(nameof(SubCategoryId))]
    public ServiceSubCategory? SubCategoryNavigation { get; set; }
    public decimal Price { get; set; }
    public TimeSpan Duration { get; set; }
}
