namespace Domain;

public class BaseEntity
{
    public long Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }
    public bool IsDeleted { get; set; }
}
