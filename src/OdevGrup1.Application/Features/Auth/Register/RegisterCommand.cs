using MediatR;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
public sealed record RegisterCommand(
    string Username,
    string Email
    ) : IRequest<Result<string>>;
