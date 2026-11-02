using Microsoft.EntityFrameworkCore;
using ReShareBlazorApp.data;
using ReShareBlazorApp.Data;


namespace ReShareBlazorApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    
}
