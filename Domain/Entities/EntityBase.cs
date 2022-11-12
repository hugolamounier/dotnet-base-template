namespace Domain.Entities;

public abstract class EntityBase<T> : IEquatable<EntityBase<T>>
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdateAt { get; set; } = DateTime.UtcNow;

    public bool Equals(EntityBase<T>? other)
    {
        return Id.Equals(other?.Id);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((EntityBase<T>) obj);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}