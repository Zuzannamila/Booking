namespace Booking.Dal.Tests.IntegrationTests;

[Collection("Integration Tests")]
public class ServiceSubCategoriesTest : BaseTest, IClassFixture<EnsureBookingDatabaseTestFixture>
{
    public ServiceSubCategoriesTest(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Theory]
    [InlineData(1, 6)]
    [InlineData(2, 6)]
    [InlineData(3, 6)]
    [InlineData(4, 4)]
    [InlineData(5, 9)]
    public void ShouldGetSubCategoriesByCategoryId(int categoryId, int expectedCount)
    {
        IQueryable<ServiceSubCategory> query = Context.ServiceSubCategories.Where(ssc => ssc.CategoryId == categoryId);
        var qs = query.ToQueryString();
        OutputHelper.WriteLine(qs);
        var subCategories = query.ToList();
        Assert.Equal(expectedCount, subCategories.Count());
    }
}
