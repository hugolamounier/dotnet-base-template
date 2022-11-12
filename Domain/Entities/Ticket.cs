namespace Domain.Entities;

public class Ticket: EntityBase<Ticket>
{
    public Guid UserId { get; set; }
}