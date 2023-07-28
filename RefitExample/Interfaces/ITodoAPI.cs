using Refit;
using RefitExample.Models;

namespace RefitExample.Interfaces;

public interface ITodoAPI
{
    [Get("/todos")]
    public Task<List<Todo>> GetTodos();
}