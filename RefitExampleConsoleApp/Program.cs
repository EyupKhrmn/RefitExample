
using Refit;
using RefitExampleConsoleApp;

ITodoAPI todoApı = RestService.For<ITodoAPI>("http://jsonplaceholder.typicode.com");
List<Todo> todos = await todoApı.GetTodos(new TodoRequest { Id = 61,UserId = 4});
foreach (var todo in todos)
{
    Console.WriteLine(todo.title);
}