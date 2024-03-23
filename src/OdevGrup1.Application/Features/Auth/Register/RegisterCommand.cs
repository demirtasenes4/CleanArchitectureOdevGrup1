using MediatR;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
public sealed record RegisterCommand(
    string FirstName,
    string LastName,
    string UserName,
    string Email,
    string Password,
    string RePassword
    ) : IRequest<Result<string>>;
