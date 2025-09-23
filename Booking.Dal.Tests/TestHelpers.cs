using Azure.Identity;
using Azure.Storage.Blobs;

namespace Booking.Dal.Tests;

public static class TestHelpers
{
    public static IConfiguration GetConfiguration() =>
        new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.testing.json", true, true)
        .Build();

    public static ApplicationDbContext GetContext(IConfiguration configuration)
    {
        DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new();
        var connectionString = configuration.GetConnectionString("Booking");
        optionsBuilder.UseSqlServer(connectionString);
        return new ApplicationDbContext(optionsBuilder.Options);
    }

    public static BlobContainerClient GetBlobContainer(IConfiguration configuration, string containerName = "media")
    {
        var accountName = configuration["Storage:AccountName"] ?? throw new InvalidOperationException("Storage:AccountName is required");
        var serviceUri = new Uri($"https://{accountName}.blob.core.windows.net");
        var serviceClient = new BlobServiceClient(serviceUri, new DefaultAzureCredential());

        var container = serviceClient.GetBlobContainerClient(containerName);
        container.CreateIfNotExists();
        return container;
    }
}
