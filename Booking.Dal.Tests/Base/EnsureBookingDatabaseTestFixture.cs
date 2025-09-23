using Booking.Dal.Initialization;

namespace Booking.Dal.Tests.Base;

public sealed class EnsureBookingDatabaseTestFixture : IDisposable
{
    public EnsureBookingDatabaseTestFixture()
    {
        var configuration = TestHelpers.GetConfiguration();
        var context = TestHelpers.GetContext(configuration);
        var container = TestHelpers.GetBlobContainer(configuration);
        SampleDataInitializer.InitializeDatabase(context, container);
    }
    public void Dispose()
    {

    }
}
