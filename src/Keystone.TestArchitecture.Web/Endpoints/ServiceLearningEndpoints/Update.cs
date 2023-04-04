using Ardalis.GuardClauses;
using System;
using FastEndpoints;
using Keystone.TestArchitecture.Core.ContributorAggregate;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.Web.Endpoints.ContributorEndpoints;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class Update : Endpoint<UpdateServiceActivityRequest, UpdateServiceActivityResponse>
{
  private readonly IRepository<ServiceActivity> _repository;

  public Update(IRepository<ServiceActivity> repository)
  {
    _repository = repository;
  }

  public override void Configure()
  {
    Put(UpdateServiceActivityRequest.Route);
    AllowAnonymous();
    Options(x => x
      .WithTags("ServiceLearningEndpoints"));
  }
  public override async Task HandleAsync(
    UpdateServiceActivityRequest request,
    CancellationToken cancellationToken)
  {
    //if (request.Name == null)
    //{
    //  ThrowError("Name is required");
    //}

    var existingServiceActivity = await _repository.GetByIdAsync(request.ID, cancellationToken);
    if (existingServiceActivity == null)
    {
      await SendNotFoundAsync();
      return;
    }
    existingServiceActivity.UpdateServiceActivity(
    request.OrganizationID,
    request.AgreedCommitment,
    request.DayOfWeek,
    request.StartTime,
    request.EndTime,
    request.ActivityDescription,
    request.Question1,
    request.Question2,
    request.Question3,
    request.IsAgreementAccepted,
    request.Status,
    request.ApprovalLevel,
    request.IsDeleted,
    request.CreatedTime,
    request.StudentID,
    request.CreatedBy,
    request.ModifiedTime,
    request.ModifiedBy,
    request.OneOffActivityDate
    );

    await _repository.UpdateAsync(existingServiceActivity, cancellationToken);

    var response = new UpdateServiceActivityResponse(
                        serviceActivity: new ServiceActivityRecord(
                        existingServiceActivity.OrganizationID,
                        existingServiceActivity.AgreedCommitment,
                        existingServiceActivity.DayOfWeek,
                        existingServiceActivity.StartTime,
                        existingServiceActivity.EndTime,
                        existingServiceActivity.ActivityDescription,
                        existingServiceActivity.Question1,
                        existingServiceActivity.Question2,
                        existingServiceActivity.Question3,
                        existingServiceActivity.IsAgreementAccepted,
                        existingServiceActivity.Status,
                        existingServiceActivity.ApprovalLevel,
                        existingServiceActivity.IsDeleted,
                        existingServiceActivity.CreatedTime,
                        existingServiceActivity.StudentID,
                        existingServiceActivity.CreatedBy,
                        existingServiceActivity.ModifiedTime,
                        existingServiceActivity.ModifiedBy,
                        existingServiceActivity.OneOffActivityDate
          )
    );

    await SendAsync(response);
  }
}

