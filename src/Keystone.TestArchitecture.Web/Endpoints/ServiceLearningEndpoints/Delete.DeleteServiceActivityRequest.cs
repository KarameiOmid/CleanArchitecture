namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class DeleteServiceActivityRequest
{
  public const string Route = "/ServiceActivity/{ServiceActivityId:int}";
  public static string BuildRoute(int serviceActivityId) => Route.Replace("{ServiceActivityId:int}", serviceActivityId.ToString());

  public int serviceActivityId { get; set; }
}
