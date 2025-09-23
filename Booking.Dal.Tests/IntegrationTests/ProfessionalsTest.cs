namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class ProfessionalsTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public ProfessionalsTest(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Fact]
    public void ShouldGetAllProfessionals()
    {
        var query = Context.Professionals;
        var qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        var professionals = query.ToList();
        Assert.Equal(10, professionals.Count);
    }
}
