using Microsoft.EntityFrameworkCore.Storage;

namespace Booking.Dal.EfStructures;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

   public virtual DbSet<Visit> Visits { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Service> Services { get; set; }
    public virtual DbSet<Venue> Venues { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(50);
    }

    public override int SaveChanges()
    {
        try
        {
            UpdateTimeStamp();
            return base.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new CustomConcurrencyException("A concurrency exception happend", ex);
        }
        catch (RetryLimitExceededException ex)
        {
            throw new CustomRetryLimitExceededException("There is a problem with SQL Server", ex);
        }
        catch (DbUpdateException ex)
        {
            throw new CustomDbUpdateException("An error occured updating database", ex);
        }
        catch (Exception ex)
        {
            throw new CustomException("An error occured updating database", ex);
        }
    }

    private void UpdateTimeStamp()
    {
        var now = DateTimeOffset.UtcNow;
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = now;
                entry.Entity.UpdatedAt = now;
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = now;
            }
        }
    }
}

      




