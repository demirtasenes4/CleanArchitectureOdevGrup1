using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using OdevGrup1.Domain.Entities;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
internal sealed class RegisterCommandHandler(UserManager<AppUser> userManager, IMapper mapper) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {

        if (request.RePassword != request.Password)
        {
            return Result<string>.Failure("Password and password repeat do not match.");
        }

        AppUser? user = mapper.Map<AppUser>(request);

        var result = await userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return Result<string>.Failure("An error occurred while registering, please try again.");
        }

        return Result<string>.Succeed("User created successfully");

    }
}
