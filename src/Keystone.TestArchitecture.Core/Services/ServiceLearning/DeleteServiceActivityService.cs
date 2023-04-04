using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Keystone.TestArchitecture.Core.ContributorAggregate.Events;
using Keystone.TestArchitecture.Core.ContributorAggregate;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using MediatR;
using Keystone.TestArchitecture.Core.Interfaces.ServiceLearning;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate.Event;

namespace Keystone.TestArchitecture.Core.Services.ServiceLearning;
public class DeleteServiceActivityService : IDeleteServiceActivityService
{
  private readonly IRepository<ServiceActivity> _repository;
  private readonly IMediator _mediator;

  public DeleteServiceActivityService(IRepository<ServiceActivity> repository, IMediator mediator)
  {
    _repository = repository;
    _mediator = mediator;
  }

  public async Task<Result> DeleteServiceActivity(int serviceActivityId)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(serviceActivityId);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new ServiceActivityDeletedEvent(serviceActivityId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}
