using Ardalis.Result;
using Keystone.TestArchitecture.Core.ProjectAggregate;

namespace Keystone.TestArchitecture.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
