using Microsoft.AspNetCore.Identity;

namespace OdevGrup1.Domain.Entities;
public sealed class AppUser : IdentityUser<Guid>
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
