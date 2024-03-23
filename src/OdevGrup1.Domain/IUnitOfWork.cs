namespace OdevGrup1.Domain.Repositories;
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

