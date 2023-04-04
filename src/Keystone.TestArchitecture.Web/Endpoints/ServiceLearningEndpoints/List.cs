using Ardalis.Specification;
using FastEndpoints;
using Keystone.TestArchitecture.Core.ContributorAggregate;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.Web.Endpoints.ContributorEndpoints;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class List : EndpointWithoutRequest<ServiceActivityListResponse>
{
  private readonly IRepository<ServiceActivity> _repository;

  public List(IRepository<ServiceActivity> repository)
  {
    _repository = repository;
  }

  public override void Configure()
  {
    Get("/ServiceActivities");
    AllowAnonymous();
    Options(x => x
      .WithTags("ServiceLearningEndpoints"));
  }
  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    
    var serviceActivities = await _repository.ListAsync(cancellationToken); // TODO: I can't go to the implementation of this method while debugging.
    var response = new ServiceActivityListResponse()
    {
      ServiceActivities = serviceActivities
        .Select(project => new ServiceActivityRecord(
                project.OrganizationID,
                project.AgreedCommitment,
                project.DayOfWeek,
                project.StartTime,
                project.EndTime,
                project.ActivityDescription,
                project.Question1,
                project.Question2,
                project.Question3,
                project.IsAgreementAccepted,
                project.Status,
                project.ApprovalLevel,
                project.IsDeleted,
                project.CreatedTime,
                project.StudentID,
                project.CreatedBy,
                project.ModifiedTime,
                project.ModifiedBy,
                project.OneOffActivityDate))
        .ToList()
    };

    await SendAsync(response);
  }
}
