using Ardalis.Specification;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate.Specifications;
public class ServiceActivityByIdSpec : Specification<ServiceActivity>, ISingleResultSpecification
{
  public ServiceActivityByIdSpec(int serviceActivityId)
  {
    Query
        .Where(serviceActivity => serviceActivity.Id == serviceActivityId);
  }
}
