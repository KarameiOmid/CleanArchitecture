using Ardalis.Result;
using FastEndpoints;
using Keystone.TestArchitecture.Core.Interfaces;
using Keystone.TestArchitecture.Core.Interfaces.ServiceLearning;
using Keystone.TestArchitecture.Web.Endpoints.ContributorEndpoints;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class Delete : Endpoint<DeleteServiceActivityRequest>
{

  private readonly IDeleteServiceActivityService _deleteServiceActivityService;

  public Delete(IDeleteServiceActivityService service)
  {
    _deleteServiceActivityService = service;
  }

  public override void Configure()
  {
    Delete(DeleteServiceActivityRequest.Route);
    AllowAnonymous();
    Options(x => x
      .WithTags("ServiceLearningEndpoints"));
  }
  public override async Task HandleAsync(
    DeleteServiceActivityRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _deleteServiceActivityService.DeleteServiceActivity(request.serviceActivityId);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync();
      return;
    }

    await SendNoContentAsync();
  }
}
