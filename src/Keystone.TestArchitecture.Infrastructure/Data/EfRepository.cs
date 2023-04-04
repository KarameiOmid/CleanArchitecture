using Ardalis.Specification.EntityFrameworkCore;
using Keystone.TestArchitecture.SharedKernel.Interfaces;

namespace Keystone.TestArchitecture.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
