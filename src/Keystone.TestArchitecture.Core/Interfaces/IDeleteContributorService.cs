using Ardalis.Result;

namespace Keystone.TestArchitecture.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(int contributorId);
}
