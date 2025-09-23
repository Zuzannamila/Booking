namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class VenueTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public VenueTest(ITestOutputHelper outputHelper) : base(outputHelper) { }

    [Fact]
    public void ShouldGetAllTheVenues()
    {
        IQueryable<Venue> query = Context.Venues;
        string qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        List<Venue> venues = query.ToList();
        Assert.NotEmpty(venues);
        Assert.Equal(10, venues.Count);
    }

    [Theory]
    [InlineData(6, 4)]
    [InlineData(12, 3)]
    [InlineData(15, 1)]
    [InlineData(32, 2)]
    [InlineData(8, 3)]
    public void ShouldGetVenueByServiceSubCategpryId(int sscId, int expectedCount)
    {
        IQueryable<Venue> query = Context.Venues.Where(x => x.Services.Any(x => x.SubCategoryId == sscId));
        string qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        List<Venue> venues = query.ToList();
        Assert.Equal(expectedCount, venues.Count());
    }

    [Theory]
    [InlineData(2, 3)]
    public void ShouldGetVenueByServiceCategpryId(int scId, int expectedCount)
    {
        IQueryable<Venue> query = Context.Venues.Where(x => x.Services.Any(x => x.CategoryId == scId));
        string qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        List<Venue> venues = query.ToList();
        Assert.Equal(expectedCount, venues.Count());
    }
}
