using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        TicketMap.Map(modelBuilder);
    }
}