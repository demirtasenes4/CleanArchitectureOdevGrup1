using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdevGrup1.Domain.Entities;

namespace OdevGrup1.Domain.Entities;
public sealed class Portfolio
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public AppUser? User { get; set; }
    public ICollection<Investment>? Investments { get; set; }
}
