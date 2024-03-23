namespace OdevGrup1.Domain.Abstraction;
public abstract class Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
}
