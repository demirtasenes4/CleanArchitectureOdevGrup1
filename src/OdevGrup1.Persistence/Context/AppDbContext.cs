using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdevGrup1.Domain.Entities;
using OdevGrup1.Domain.Repositories;

namespace OdevGrup1.Persistence.Context;
internal sealed class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>, IUnitOfWork
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public AppUser? Users { get; set; }
    public Investment? Investments { get; set; }
    public Portfolio? Portfolios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityRoleClaim<Guid>>();
        builder.Ignore<IdentityUserClaim<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();
        builder.Ignore<IdentityUserRole<Guid>>();
    }
}
