namespace Booking.Dal.Tests.Base;

public abstract class BaseTest : IDisposable
{
    protected readonly IConfiguration Configuration;
    protected readonly ApplicationDbContext Context;
    protected readonly ITestOutputHelper OutputHelper;

    public BaseTest(ITestOutputHelper outputHelper)
    { 
        Configuration = TestHelpers.GetConfiguration();
        Context = TestHelpers.GetContext(Configuration);
        OutputHelper = outputHelper;
    }
    public virtual void Dispose()
    {
        Context.Dispose();
    }
}
