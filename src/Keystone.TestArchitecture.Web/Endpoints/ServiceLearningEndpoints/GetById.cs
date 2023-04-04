using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.Web.Endpoints.ContributorEndpoints;
using FastEndpoints;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate.Specifications;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Microsoft.AspNetCore.Http.HttpResults;


namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class GetById : Endpoint<GetServiceActivityByIdRequest, ServiceActivityRecord>
{
  private readonly IRepository<ServiceActivity> _repository;

  public GetById(IRepository<ServiceActivity> repository)
  {
    _repository = repository;
  }

  public override void Configure()
  {
    Get(GetServiceActivityByIdRequest.Route);
    AllowAnonymous();
    Options(x => x
      .WithTags("ServiceLearningEndpoints"));
  }
  public override async Task HandleAsync(GetServiceActivityByIdRequest request,
    CancellationToken cancellationToken)
  {
    var spec = new ServiceActivityByIdSpec(request.serviceActivityId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null)
    {
      await SendNotFoundAsync();
      return;
    }

    //TODO: its beter to use automapper here as it has to many properties
    var response = new ServiceActivityRecord(
        entity.OrganizationID,
        entity.AgreedCommitment,
        entity.DayOfWeek,
        entity.StartTime,
        entity.EndTime,
        entity.ActivityDescription,
        entity.Question1,
        entity.Question2,
        entity.Question3,
        entity.IsAgreementAccepted,
        entity.Status,
        entity.ApprovalLevel,
        entity.IsDeleted,
        entity.CreatedTime,
        entity.StudentID,
        entity.CreatedBy,
        entity.ModifiedTime,
        entity.ModifiedBy,
        entity.OneOffActivityDate);

    await SendAsync(response);
  }
}
