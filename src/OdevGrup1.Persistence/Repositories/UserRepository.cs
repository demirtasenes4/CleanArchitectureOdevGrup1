using OdevGrup1.Application.Repositories;
using OdevGrup1.Domain.Entities;
using OdevGrup1.Persistence.Context;

namespace OdevGrup1.Persistence.Repositories;
internal class UserRepository : Repository<AppUser>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
