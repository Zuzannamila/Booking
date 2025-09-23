using Azure.Storage.Blobs.Models;

namespace Booking.Dal.Initialization;

public class BlobDataInitializer
{
    public static void 
        
        SeedPhoto(
        ApplicationDbContext context, 
        BlobContainerClient blobContainer, 
        PhotoOwnerType ownerType,
        Guid ownerId, string photoFile, 
        int sortOrder = 0, 
        bool isPrimary = true)
    {
        Guid photoId = Guid.NewGuid();
        string ext = Path.GetExtension(photoFile).ToLowerInvariant();

        string key = ownerType == PhotoOwnerType.Professional ?
            $"professionals/{ownerId}/photos/{photoId}/original{ext}" :
            $"venues/{ownerId}/photos/{photoId}/original{ext}";

        BlobClient blob = blobContainer.GetBlobClient(key);

        using FileStream fs = File.OpenRead(photoFile);
        BlobHttpHeaders headers = new()
        {
            ContentType = GuessContentType(ext),
            CacheControl = "no-cache"
        };
        blob.Upload(fs, overwrite: true);
        blob.SetHttpHeaders(headers);

        Photo p = new()
        {
            Id = photoId,
            OwnerType = ownerType,
            OwnerId = ownerId,
            BlobKey = key,
            OriginalFileName = Path.GetFileName(photoFile),
            ContentType = headers.ContentType,
            SortOrder = sortOrder,
            IsPrimary = isPrimary
        };
        context.Photos.Add(p);
        context.SaveChanges();
    }

    private static string GuessContentType(string ext) => ext switch 
    {
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".webp" => "image/webp",
            _ => "application/octet-stream"
     };

    public static void CleanAllSeedBlobs(BlobContainerClient blobContainer)
    {
        DeleteByPrefix(blobContainer, "professionals/");
        DeleteByPrefix(blobContainer, "venues/");
    }

    private static void DeleteByPrefix(BlobContainerClient blobContainer, string prefix)
    {
        foreach(var item in blobContainer.GetBlobs(prefix :  prefix))
        {
            var blob = blobContainer.GetBlobClient(item.Name);
            blob.DeleteIfExists();
        }
    }
}
