namespace Booking.Dal.EfStructures;
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var context = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = context.GetConnectionString("Booking");
        Console.WriteLine(connectionString);
        optionBuilder.UseSqlServer(connectionString);
        return new ApplicationDbContext(optionBuilder.Options);
    }
}
