using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class AppContext: DbContext
{
    public AppContext(DbContextOptions<AppContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}