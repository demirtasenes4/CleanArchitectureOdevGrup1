using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
public sealed record RegisterCommand(
    string Username,
    string Email
    ) : IRequest<Result<string>>;
