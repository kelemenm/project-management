namespace Domain;

public class Comment : BaseEntity
{
    public string Content { get; set; }
    public Ticket Ticket { get; set; }
}
