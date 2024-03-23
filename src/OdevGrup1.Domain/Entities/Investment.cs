using OdevGrup1.Domain.Abstraction;

namespace OdevGrup1.Domain.Entities;
public sealed class Investment : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int BuyPrice { get; set; } = 0;
    public int Qty { get; set; } = 0;
}
