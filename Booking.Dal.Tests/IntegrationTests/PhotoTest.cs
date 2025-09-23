namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class PhotoTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public PhotoTest(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Fact]
    public void ShouldGetAllPhotos()
    {
        var query = Context.Photos;
        string qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        List<Photo> photos = query.ToList();
        Assert.Equal(46, photos.Count);
    }
}
