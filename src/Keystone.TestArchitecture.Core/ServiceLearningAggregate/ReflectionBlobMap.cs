using System.Reflection.Metadata;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;

public class ReflectionBlobMap : EntityBase, IAggregateRoot
{
  public int ReflectionID { get; set; }
  public long BlobID { get; set; }
  public int ReflectionOrder { get; set; }
  public virtual Reflection? Reflection { get; set; }
  //public virtual Blob Attachment { get; set; }

}
