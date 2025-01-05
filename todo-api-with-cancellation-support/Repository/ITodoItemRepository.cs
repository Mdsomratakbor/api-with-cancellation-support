using todo_api_with_cancellation_support.Models;

namespace todo_api_with_cancellation_support.Repository;

public interface ITodoItemRepository
{
    Task<List<TodoItem>> GetAllAsync(CancellationToken cancellationToken);
    Task<TodoItem?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task AddAsync(TodoItem item, CancellationToken cancellationToken);
    Task UpdateAsync(TodoItem item, CancellationToken cancellationToken);
    Task DeleteAsync(int id, CancellationToken cancellationToken);
}
