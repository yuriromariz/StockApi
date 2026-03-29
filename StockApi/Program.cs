using Microsoft.EntityFrameworkCore;
using StockApi.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Services Configuration (Dependency Injection)
builder.Services.AddControllers();

// Adds OpenAPI support (essential for .NET 10)
builder.Services.AddOpenApi(); 

// Database Connection Setup
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// 2. Request Pipeline Configuration (Middleware)

// Enable the OpenAPI JSON generation
app.MapOpenApi();

// Enable the Swagger UI (The visual interface)
// We point it to the default .NET 10 OpenAPI path (/openapi/v1.json)
app.UseSwaggerUI(options => 
{
    options.SwaggerEndpoint("/openapi/v1.json", "StockApi v1");
    options.RoutePrefix = "swagger"; // Access via http://localhost:5109/swagger
});

app.UseHttpsRedirection();

// Maps the routes from the Controllers folder
app.MapControllers();

app.Run();