using OdevGrup1.Domain.Abstraction;

namespace OdevGrup1.Domain.Entities;
public sealed class Portfolio : Entity
{
    public Guid UserId { get; set; }
    public AppUser? User { get; set; }
    public ICollection<Investment>? Investments { get; set; }
}
