using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mappings;

public class MappingBase<T>
{
    private readonly ModelBuilder _modelBuilder;

    public MappingBase(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
        BaseMapping<EntityBase<T>>();
    }

    public ModelBuilder GetBuilder() => _modelBuilder;

    private void BaseMapping<TS>() where TS : EntityBase<T>
    {
        _modelBuilder.Entity<TS>(entity =>
        {
            entity.ToTable(typeof(T).Name);
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Id).HasDefaultValueSql("NEWID()");
        });
    }
}
