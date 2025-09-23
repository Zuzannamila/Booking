namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class ClientsTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public ClientsTest(ITestOutputHelper output) : base(output) { }

    [Fact]
    public void ShouldGetAllClients()
    {
        var query = Context.Clients;
        string qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        List<Client> clients = query.ToList();
        Assert.Equal(9, clients.Count());
    }
}
