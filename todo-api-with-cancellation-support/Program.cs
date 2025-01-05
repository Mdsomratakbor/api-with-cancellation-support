using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using todo_api_with_cancellation_support.Data;
using todo_api_with_cancellation_support.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbconnection")));
builder.Services.AddScoped<ITodoItemRepository, TodoItemRepository>();
// Add Swagger services
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Todo API with Cancellation Support",
        Version = "v1",
        Description = "API documentation for managing Todo items with cancellation token support.",
        Contact = new OpenApiContact
        {
            Name = "Md Samrat",
            Email = "samrat876@gmail.com",
            Url = new Uri("https://yourwebsite.com")
        }
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API with Cancellation Support v1");
    c.RoutePrefix = string.Empty; // Set Swagger UI at the root URL
});
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
