using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading;
using todo_api_with_cancellation_support.Models;
using todo_api_with_cancellation_support.Repository;

namespace todo_api_with_cancellation_support.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoItemController : ControllerBase
{
    private readonly ITodoItemRepository _todoItemRepository;

    public TodoItemController(ITodoItemRepository todoItemRepository)
    {
        _todoItemRepository = todoItemRepository;
    }

    [HttpGet("GetAllWithoutCancellationToken")]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetAllWithoutCancellationToken()
    {
        Console.WriteLine("Fetching all TodoItems...");
        await Task.Delay(8000);
        var items = await _todoItemRepository.GetAllAsync();
        Console.WriteLine($"Fetched {items.Count()} TodoItems.");
        return Ok(items);
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetAll(CancellationToken cancellationToken)
    {
        try
        {
            //await Task.Delay(3000, cancellationToken);
            // Console.WriteLine("Fetching all TodoItems...1");

            // await Task.Delay(5000, cancellationToken);
            //Console.WriteLine("Fetching all TodoItems...2");

            // await Task.Delay(9000, cancellationToken);
            //  Console.WriteLine("Fetching all TodoItems...3");

            await PrintMessage(cancellationToken);
            

            var items = await _todoItemRepository.GetAllAsync(cancellationToken);
            Console.WriteLine($"Fetched {items.Count()} TodoItems.");
            return Ok(items);
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Request was canceled.");
            return BadRequest("Request was canceled.");
        }
    }

    private async Task PrintMessage(CancellationToken cancellationToken)
    {
        for (int i = 0; i < 100000; i++)
        {
          await  Task.Run(() => Console.WriteLine($"Fetching all TodoItems...{i}"), cancellationToken);

        }
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> GetById(int id, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Fetching TodoItem with ID: {id}");
        var item = await _todoItemRepository.GetByIdAsync(id, cancellationToken);
        if (item == null)
        {
            Console.WriteLine("TodoItem not found.");
            return NotFound();
        }
        Console.WriteLine("TodoItem found.");
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<TodoItem>> Create(TodoItem todoItem, CancellationToken cancellationToken)
    {
        Console.WriteLine("Creating a new TodoItem...");
        await _todoItemRepository.AddAsync(todoItem, cancellationToken);
        Console.WriteLine("TodoItem created successfully.");
        return CreatedAtAction(nameof(GetById), new { id = todoItem.Id }, todoItem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, TodoItem todoItem, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Updating TodoItem with ID: {id}");
        if (id != todoItem.Id)
        {
            Console.WriteLine("Mismatched ID in the request.");
            return BadRequest();
        }
        await _todoItemRepository.UpdateAsync(todoItem, cancellationToken);
        Console.WriteLine("TodoItem updated successfully.");
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Deleting TodoItem with ID: {id}");
        var item = await _todoItemRepository.GetByIdAsync(id, cancellationToken);
        if (item == null)
        {
            Console.WriteLine("TodoItem not found.");
            return NotFound();
        }
        await _todoItemRepository.DeleteAsync(id, cancellationToken);
        Console.WriteLine("TodoItem deleted successfully.");
        return NoContent();
    }
}
