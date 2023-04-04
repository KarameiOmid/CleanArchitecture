using System;
using FastEndpoints;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class Create : Endpoint<CreateServiceActivityRequest, CreateServiceActivityResponse>
{
  private readonly IRepository<ServiceActivity> _repository;

  public Create(IRepository<ServiceActivity> repository)
  {
    _repository = repository;
  }

  public override void Configure()
  {
    Post(CreateServiceActivityRequest.Route);
    AllowAnonymous();
    Options(x => x
      .WithTags("ServiceLearningEndpoints"));
  }
  public override async Task HandleAsync(
    CreateServiceActivityRequest request,
    CancellationToken cancellationToken)
  {
    #region ???
    // TODO:  should I check this one by one or there is a better way to do it?

    //if (
    //    request.OrganizationID == 0 ||
    //    request.AgreedCommitment == null ||
    //    request.DayOfWeek == null ||
    //    request.StartTime == TimeSpan.Zero ||
    //    request.EndTime == TimeSpan.Zero ||
    //    request.ActivityDescription == null ||
    //    request.Question1 == null ||
    //    request.Question2 == null ||
    //    request.Question3 == null ||
    //    request.IsAgreementAccepted ||
    //    request.Status ||
    //    request.ApprovalLevel == null ||
    //    request.IsDeleted == null ||
    //    request.CreatedTime == null ||
    //    request.StudentID == null ||
    //    request.CreatedBy == null ||
    //    request.ModifiedTime == null ||
    //    request.ModifiedBy == null ||
    //    request.OneOffActivityDate == 1
    //   )
    //{
    //ThrowError("Name is required");
    //}
    #endregion

    var newServiceActivity = new ServiceActivity(

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

    //ModifiedBy = Guid.Parse("B2F0D350-6AE8-4CA8-B37D-A674005C74F1") //request.CurrentUser.ID 
    // TODO: how do I get current user?
    );

    var createdItem = await _repository.AddAsync(newServiceActivity, cancellationToken);
    var response = new CreateServiceActivityResponse
    (
      organizationID: createdItem.OrganizationID,
      agreedCommitment: createdItem.AgreedCommitment,
      dayOfWeek: createdItem.DayOfWeek,
      startTime: createdItem.StartTime,
      endTime: createdItem.EndTime,
      activityDescription: createdItem.ActivityDescription,
      question1: createdItem.Question1,
      question2: createdItem.Question2,
      question3: createdItem.Question3,
      isAgreementAccepted: createdItem.IsAgreementAccepted,
      status: createdItem.Status,
      approvalLevel: createdItem.ApprovalLevel,
      isDeleted: createdItem.IsDeleted,
      createdTime: createdItem.CreatedTime,
      studentID: createdItem.StudentID,
      createdBy: createdItem.CreatedBy,
      modifiedTime: createdItem.ModifiedTime,
      modifiedBy: createdItem.ModifiedBy,
      neOffActivityDate: createdItem.OneOffActivityDate
    );

    await SendAsync(response);
  }
}
