using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevGrup1.Domain.Entities;
public sealed class Investment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int BuyPrice { get; set; } = 0;
    public int Qty { get; set; } = 0;
}
