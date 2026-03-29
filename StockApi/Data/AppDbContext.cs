using Microsoft.EntityFrameworkCore;
using StockApi.Models;

namespace StockApi.Data;

public class AppDbContext : DbContext
{
    // Este construtor permite que o Program.cs injete as configurações do SQL Server
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}