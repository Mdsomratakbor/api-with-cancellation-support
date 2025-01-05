using Microsoft.EntityFrameworkCore;
using todo_api_with_cancellation_support.Data;
using todo_api_with_cancellation_support.Models;

namespace todo_api_with_cancellation_support.Repository;

public class TodoItemRepository : ITodoItemRepository
{
    private readonly AppDbContext _context;

    public TodoItemRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<TodoItem>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.ToDoItems.ToListAsync(cancellationToken);
    }
    public async Task<List<TodoItem>> GetAllAsync()
    {
        return await _context.ToDoItems.ToListAsync();
    }
    public async Task<TodoItem?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.ToDoItems.FindAsync(new object[] { id }, cancellationToken);
    }

    public async Task AddAsync(TodoItem item, CancellationToken cancellationToken)
    {
        await _context.ToDoItems.AddAsync(item, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(TodoItem item, CancellationToken cancellationToken)
    {
        _context.ToDoItems.Update(item);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var item = await _context.ToDoItems.FindAsync(new object[] { id }, cancellationToken);
        if (item != null)
        {
            _context.ToDoItems.Remove(item);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
