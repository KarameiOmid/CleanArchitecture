using Ardalis.Specification;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate.Specifications;
public class ServiceActivityByIdSpec : Specification<ServiceActivity>, ISingleResultSpecification
{
  public ServiceActivityByIdSpec(int serviceActivityId)
  {
    // Other ORM can be used here too. Like Dapper, Entity Framework, etc.
    Query
        .Where(serviceActivity => serviceActivity.Id == serviceActivityId);
  }
}
