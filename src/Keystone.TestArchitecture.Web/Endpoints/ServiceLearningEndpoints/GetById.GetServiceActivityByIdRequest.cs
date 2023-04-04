namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class GetServiceActivityByIdRequest
{
  public const string Route = "/ServiceLearning/ServiceActivity/{serviceActivityId:int}";
  public static string BuildRoute(int serviceActivityId) => Route.Replace("{serviceActivityId:int}", serviceActivityId.ToString());

  public int serviceActivityId { get; set; }

}
