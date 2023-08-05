using System.Reflection;
using Keystone.TestArchitecture.Core.ContributorAggregate;
using Keystone.TestArchitecture.Core.ProjectAggregate;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Keystone.TestArchitecture.SharedKernel;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Keystone.TestArchitecture.Infrastructure.Data;

public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher? dispatcher)
      : base(options)
  {
    _dispatcher = dispatcher;
  }

  public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
  public DbSet<Project> Projects => Set<Project>();
  public DbSet<Contributor> Contributors => Set<Contributor>();
  public DbSet<ServiceActivity> ServiceActivity => Set<ServiceActivity>();
  public DbSet<DevelopmentalGoal> DevelopmentalGoal => Set<DevelopmentalGoal>();
  public DbSet<LogService> LogService => Set<LogService>();
  public DbSet<Organization> Organization => Set<Organization>();
  public DbSet<Reflection> Reflection => Set<Reflection>();
  public DbSet<ReflectionBlobMap> ReflectionBlobMap => Set<ReflectionBlobMap>();
  public DbSet<ServiceActivityBlobMap> ServiceActivityBlobMap => Set<ServiceActivityBlobMap>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    //TODO: if want to add all the entities here then AppDbContext will be a mess, is there a better way to do this?

    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
