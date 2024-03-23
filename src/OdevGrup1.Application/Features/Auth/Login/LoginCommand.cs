using MediatR;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string UserNameOrEmail,
    string Password
) : IRequest<Result<string>>;
