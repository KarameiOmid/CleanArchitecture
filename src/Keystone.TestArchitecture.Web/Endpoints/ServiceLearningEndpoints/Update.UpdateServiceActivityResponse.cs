using Keystone.TestArchitecture.Web.Endpoints.ContributorEndpoints;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class UpdateServiceActivityResponse
{
  public UpdateServiceActivityResponse(ServiceActivityRecord serviceActivity)
  {
    ServiceActivity = serviceActivity;
  }
  public ServiceActivityRecord ServiceActivity { get; set; }
}

