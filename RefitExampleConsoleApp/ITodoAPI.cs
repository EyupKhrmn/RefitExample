using Refit;

namespace RefitExampleConsoleApp;

public interface ITodoAPI
{
    [Get("/todos?id={request.Id}&UserId={request.UserId}")]
    public Task<List<Todo>> GetTodos(TodoRequest request);
}