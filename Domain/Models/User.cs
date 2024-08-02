namespace Domain;

public class User : BaseEntity
{
    public string? Email { get; set; }
    public ICollection<Project> Projects { get; set; } = [];
    public ICollection<Ticket> Tickets { get; set; } = [];
}
