using Keystone.TestArchitecture.Core.ContributorAggregate;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using FastEndpoints;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Keystone.TestArchitecture.Web.Endpoints.ContributorEndpoints;

public class Create : Endpoint<CreateContributorRequest, CreateContributorResponse>
{
  private readonly IRepository<Contributor> _repository;

  public Create(IRepository<Contributor> repository)
  {
    _repository = repository;
  }

  //this is how minimal Api is configured.
  public override void Configure()
  {
    Post(CreateContributorRequest.Route); // it uses a post method instead of a attribute post/ it returns IResult which is what minimal APIs return.
    AllowAnonymous();
    Options(x => x
      .WithTags("ContributorEndpoints"));
  }
  public override async Task HandleAsync(
    CreateContributorRequest request,
    CancellationToken cancellationToken)
  {
    if (request.Name == null)
    {
      ThrowError("Name is required");
    }

    var newContributor = new Contributor(request.Name);
    var createdItem = await _repository.AddAsync(newContributor, cancellationToken);
    var response = new CreateContributorResponse
    (
      id: createdItem.Id,
      name: createdItem.Name
    );

    await SendAsync(response);
  }
}
