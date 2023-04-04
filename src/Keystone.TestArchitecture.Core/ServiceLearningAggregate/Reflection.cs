using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;

public class Reflection : EntityBase, IAggregateRoot
{
  public Reflection()
  {
    ReflectionBlobMappings = new List<ReflectionBlobMap>();
  }
  public int StudentSynID { get; set; }
  public bool? ReflectionAfterTwentyHours { get; set; }
  public string? Reflection1Comments { get; set; }
  public int? Reflection1Status { get; set; }
  public bool? ReflectionAfterFortyHours { get; set; }
  public string? Reflection2Comments { get; set; }
  public int? Reflection2Status { get; set; }
  public bool? ReflectionAfterSeventyFiveHours { get; set; }
  public string? Reflection3Comments { get; set; }
  public int? Reflection3Status { get; set; }
  public string? LearningOutcomes { get; set; }
  public virtual List<ReflectionBlobMap> ReflectionBlobMappings { get; set; }
}
