using OdevGrup1.Application.Features.Auth.Register;
using TS.Result;

namespace OdevGrup1.Application.Services;
public interface IAuthService
{
    Task<Result<string>> CreateAsync(RegisterCommand request, CancellationToken cancellationToken); 
}
