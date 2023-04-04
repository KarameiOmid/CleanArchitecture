using System.Reflection.Metadata;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;

public class ServiceActivityBlobMap : EntityBase, IAggregateRoot
{
  public int ServiceActivityID { get; set; }
  public long BlobID { get; set; }
  public int reflectionOrder { get; set; }
  public virtual ServiceActivity? ServiceActivity { get; set; }
  //public virtual Blob Attachment { get; set; }

}


