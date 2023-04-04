using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate.Event;
public class ServiceActivityDeletedEvent : DomainEventBase
{
  public int ServiceActivityId { get; set; }

  public ServiceActivityDeletedEvent(int serviceActivityId)
  {
    ServiceActivityId = serviceActivityId;
  }
}
