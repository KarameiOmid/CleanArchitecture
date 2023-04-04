
using Ardalis.Result;

namespace Keystone.TestArchitecture.Core.Interfaces.ServiceLearning;
public interface IDeleteServiceActivityService
{
  public Task<Result> DeleteServiceActivity(int serviceActivityId);
}
