namespace Booking.Dal.EfStructures;
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = "Data Source=(localdb)\\mssqllocaldb; Integrated Security=true; Initial Catalog=BookingDev";
        optionBuilder.UseSqlServer(connectionString);
        Console.WriteLine(connectionString);
        return new ApplicationDbContext(optionBuilder.Options);
    }
}
