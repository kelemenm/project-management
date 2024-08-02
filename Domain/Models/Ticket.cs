namespace Domain;

public class Ticket : BaseEntity
{
    public string Title { get; set; }
    public string Descreption { get; set; }
    public DateTime DeadLine { get; set; }
    public TicketStatus Status { get; set; }
    public User User { get; set; }
    public Project Project{ get; set; }
    public ICollection<AttachmentFile> Attachments { get; set; }
}
