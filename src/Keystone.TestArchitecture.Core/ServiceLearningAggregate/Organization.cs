using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;
public class Organization : EntityBase, IAggregateRoot
{
  public string? Name { get; set; }
  public string? Address { get; set; }
  public string? MainContact { get; set; }
  public string? Phone { get; set; }
  public string? Website { get; set; }
  public string? Email { get; set; }
  public bool? IsDeleted { get; set; }
  public bool? IsDraft { get; set; }
  public int? ApplicantSynergeticID { get; set; }
  public string? ApplicantName { get; set; }

  //navigation property
  public virtual ICollection<DevelopmentalGoal>? DevelopmentalGoals { get; set; }
  public virtual ICollection<ServiceActivity>? ServiceActivities { get; set; }
  //public virtual List<Blob>? Attachments { get; set; }
}
