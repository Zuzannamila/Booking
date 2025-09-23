using Microsoft.EntityFrameworkCore.Storage;

namespace Booking.Dal.EfStructures;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Visit> Visits { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Professional> Professionals { get; set; }
    public virtual DbSet<Venue> Venues { get; set; }
    public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
    public virtual DbSet<ServiceSubCategory> ServiceSubCategories { get; set; }
    public virtual DbSet<Photo> Photos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseEntity>()
                .UseTpcMappingStrategy()
                .HasQueryFilter(b => !b.IsDeleted)
                .Property(b => b.Timestamp)
                .IsRowVersion();
        modelBuilder.Entity<ServiceCategory>()
            .Property(x => x.Id)
            .ValueGeneratedNever();

        foreach (var entity in modelBuilder.Model.GetEntityTypes()
           .Where(et => typeof(BaseEntity).IsAssignableFrom(et.ClrType) && !et.IsAbstract() && !et.IsOwned()))
        {
            var b = modelBuilder.Entity(entity.ClrType);

            b.Property(nameof(BaseEntity.Id)).HasColumnOrder(0);

            int order = 1;
            foreach (var prop in b.Metadata.GetProperties().Where(p => p.PropertyInfo?.DeclaringType == entity.ClrType))
            {
                b.Property(prop.Name).HasColumnOrder(order++);
            }

            const int auditStart = 95;
            b.Property(nameof(BaseEntity.CreatedAt)).HasColumnOrder(auditStart);
            b.Property(nameof(BaseEntity.UpdatedAt)).HasColumnOrder(auditStart + 1);
            b.Property(nameof(BaseEntity.DeletedAt)).HasColumnOrder(auditStart + 2);
            b.Property(nameof(BaseEntity.IsDeleted)).HasColumnOrder(auditStart + 3);
            b.Property(nameof(BaseEntity.Timestamp)).HasColumnOrder(auditStart + 4);
        }
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Professional).Assembly);
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
            else if(entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.DeletedAt = now;

            }
        }
    }
}

      




