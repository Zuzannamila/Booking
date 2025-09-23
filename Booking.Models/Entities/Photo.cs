namespace Booking.Models.Entities;

[Table("Photos", Schema = "dbo")]
public class Photo : BaseEntity
{
    public PhotoOwnerType OwnerType { get; set; }
    public  Guid OwnerId { get; set; }

    public string BlobKey { get; set; } = null!;
    public string? MediumKey { get; set; }
    public string? ThumbKey { get; set; }

    public string OriginalFileName { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public int? Width { get; set; }
    public int? Height { get; set; }

    public int SortOrder { get; set; }
    public bool IsPrimary { get; set; }
}
