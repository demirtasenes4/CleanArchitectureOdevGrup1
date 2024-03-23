using MediatR;
using OdevGrup1.Application.Services;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
internal sealed class RegisterCommandHandler(IAuthService authService) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var result = await authService.CreateAsync(request, cancellationToken);
        
        return result;

    }
}
