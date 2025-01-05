using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using todo_api_with_cancellation_support.Models;

namespace todo_api_with_cancellation_support.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<TodoItem> ToDoItems { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var todoItems = new List<TodoItem>();
        for (int i = 1; i <= 2000; i++)
        {
            todoItems.Add(new TodoItem
            {
                Id = i,
                Title = $"Todo Item #{i}",
                Description = $"Description for Todo Item #{i}",
                CreatedDate = DateTime.UtcNow.AddDays(-i),
                UpdatedDate = DateTime.UtcNow,
                Status = i % 2 == 0 ? "COMPLETED" : "NEW"
            });
        }

        modelBuilder.Entity<TodoItem>().HasData(todoItems);
    }
}
