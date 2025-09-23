namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class ServiceCategoryTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public ServiceCategoryTest(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Fact]
    public void ShouldGetAllServiceCatgories()
    {
        IQueryable<ServiceCategory> query = Context.ServiceCategories;
        var qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        var categoryServices = query.ToList();
        Assert.NotEmpty(categoryServices);
        Assert.Equal(5, categoryServices.Count);
    }
}
