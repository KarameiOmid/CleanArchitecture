using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;
public class LogService : EntityBase, IAggregateRoot
{
  public int ServiceActivityID { get; set; }
  public DateTime Date { get; set; }
  public TimeSpan StartTime { get; set; }
  public TimeSpan FinishTime { get; set; }
  public string? Activity { get; set; }
  public TimeSpan TimeLogged { get; set; }
  public int Status { get; set; }
  public string? RejectionReason { get; set; }
  public string? SupervisorName { get; set; }
  public string? SupervisorTitle { get; set; }
  public string? SupervisorPhone { get; set; }
  public string? SupervisorEmail { get; set; }
  public virtual ServiceActivity? ServiceActivity { get; set; }
}
