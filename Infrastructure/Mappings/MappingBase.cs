using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mappings;

public class MappingBase<T> where T : class
{
    private readonly ModelBuilder _modelBuilder;

    public MappingBase(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
        BaseMapping();
    }

    public ModelBuilder GetBuilder() => _modelBuilder;

    private void BaseMapping()
    {
        _modelBuilder.Entity(typeof(T)).ToTable(typeof(T).Name);
        _modelBuilder.Entity(typeof(T)).HasKey("Id");
        _modelBuilder.Entity(typeof(T)).Property("Id").HasDefaultValueSql("NEWID()");
    }
}
