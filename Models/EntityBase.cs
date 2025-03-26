namespace crud_dot_net.Models;

public abstract class EntityBase
{
    public Guid Uuid { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset LastModified { get; set; }
    
    public void UpdateLastModified()
    {
        LastModified = DateTimeOffset.UtcNow;
    }
}