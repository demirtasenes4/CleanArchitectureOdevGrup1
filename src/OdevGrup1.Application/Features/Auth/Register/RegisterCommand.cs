using MediatR;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
public sealed record RegisterCommand(
    string Username,
    string Email,
    string Password
    ) : IRequest<Result<string>>;
