namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class ServicesTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public ServicesTest(ITestOutputHelper outputHelper) : base(outputHelper) { }

    [Theory]
    [InlineData("Dry By", 12)]
    [InlineData("Hershesons", 7)]
    [InlineData("Larry King", 6)]
    [InlineData("Gielly Green", 5)]
    [InlineData("The Six", 5)]
    [InlineData("Cowshed Spa", 6)]
    [InlineData("AMA", 6)]
    [InlineData("Agua London", 4)]
    [InlineData("Aveda Lifestyle Salon and Spa", 3)]
    [InlineData("Shoreditch Nails", 4)]
    public void ShouldGetAllServicesForVenueId(string venueName, int expectedCount)
    {
        IQueryable<Service> query = Context.Venues.AsNoTracking().Where(v => v.Name == venueName).SelectMany(v => v.Services);
        OutputHelper.WriteLine(query.ToQueryString());
        var services = query.ToList();
        Assert.Equal(expectedCount, services.Count());
    }
}
