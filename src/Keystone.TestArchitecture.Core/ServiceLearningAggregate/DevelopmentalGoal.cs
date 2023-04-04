using System.Reflection.Metadata;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;
public class DevelopmentalGoal : EntityBase, IAggregateRoot
{
  public string? Name { get; set; }
  public byte[]? Icon { get; set; }
  public bool? IsDeleted { get; set; }
 // public virtual List<Blob>? Attachments { get; set; }

  //navigation property
  public virtual ICollection<Organization>? Organizations { get; set; }
}

