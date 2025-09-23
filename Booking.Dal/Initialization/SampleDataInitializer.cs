namespace Booking.Dal.Initialization;

public static class SampleDataInitializer
{
    private static void SeedData(ApplicationDbContext context, BlobContainerClient container)
    {
        ProcessInsert(context, context.ServiceCategories, SampleData.ServiceCategories);
        ProcessInsert(context, context.Venues, SampleData.Venues);
        List<Professional> professionalsWithFK =  PreProcessProfessionalsInsert(context, SampleData.Professionals);
        ProcessInsert(context, context.Professionals, professionalsWithFK);
        ProcessInsert(context, context.Clients, SampleData.Clients);

        SeedProfessionalsPhotos(context, container);
        SeedVenuePhotos(context, container);

        static void ProcessInsert<TEntity>(
            ApplicationDbContext context,
            DbSet<TEntity> table,
            List<TEntity> records
            ) where TEntity : class
        {
            if(table.Any())
            {
                return;
            }

            try
            {
                table.AddRange(records);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Seeding failed {ex}");
                throw;
            }
        }

        static List<Professional> PreProcessProfessionalsInsert(ApplicationDbContext context, List<Professional> professionals) 
        {
            List<Guid> venueIds = context.Venues.Select(x => x.Id).ToList();
            int min = Math.Min(professionals.Count, venueIds.Count);
            for(int i = 0; i < min; i++)
            {
                professionals[i].VenueId = venueIds[i];
            }
            return professionals;
        }
    }

    private static void SeedProfessionalsPhotos(ApplicationDbContext context, BlobContainerClient blobContainer)
    {
        string baseDir = Path.Combine(AppContext.BaseDirectory, "SeedImages", "Professionals");
        if (!Directory.Exists(baseDir)) return;

        var photos = Directory.GetFiles(baseDir, "*.jpg").OrderBy(f => f).ToList();
        List<Professional> professionals = context.Professionals.AsNoTracking().OrderBy(x => x.Id).ToList();
        int min = Math.Min(professionals.Count, photos.Count);  

        for(int i = 0; i < min; i++)
        {
            BlobDataInitializer.SeedPhoto(context, blobContainer, PhotoOwnerType.Professional, professionals[i].Id, photos[i]);
        }
    }

    private static void SeedVenuePhotos(ApplicationDbContext context, BlobContainerClient blobContainer)
    {
        List<Venue> venues = context.Venues.AsNoTracking().OrderBy(x => x.Id).ToList();
        for(int i = 0; i < venues.Count; i++)
        {
            string venueName = venues[i].Name.Replace(" ", "");
            string baseDir = Path.Combine(AppContext.BaseDirectory, "SeedImages", "Venues", venueName);
            if (!Directory.Exists(baseDir)) return;
            var photos = Directory.GetFiles(baseDir).OrderBy(p => p).ToList();
            foreach(var photo in photos)
            {
                BlobDataInitializer.SeedPhoto(context, blobContainer, PhotoOwnerType.Venue, venues[i].Id, photo);
            }
        }
    }

    private static void DropAndCreateDatabase(ApplicationDbContext context)
    {
        context.Database.EnsureDeleted();
        context.Database.Migrate();
    }

    public static void InitializeDatabase(ApplicationDbContext context, BlobContainerClient container)
    {
        DropAndCreateDatabase(context);
        BlobDataInitializer.CleanAllSeedBlobs(container);
        SeedData(context, container);
    }
}
