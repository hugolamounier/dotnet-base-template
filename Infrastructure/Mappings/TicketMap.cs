using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mappings;

public static class TicketMap
{
    public static void Map(ModelBuilder modelBuilder)
    {
        var baseModelBuilder = new MappingBase<Ticket>(modelBuilder).GetBuilder();
        
        baseModelBuilder.Entity<Ticket>(entity =>
        {
            entity.Property(p => p.UserId).IsRequired();
        });
    }
}