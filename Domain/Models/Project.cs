namespace Domain;

public class Project : BaseEntity
{
    public string Title { get; set; }
    public string Descreption { get; set; }
    public ICollection<User> Users { get; set; } = [];
    public ICollection<Ticket> Tickets { get; set; } = [];
}
