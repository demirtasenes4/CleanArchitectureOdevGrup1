using MediatR;
using Microsoft.AspNetCore.Identity;
using OdevGrup1.Domain.Entities;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
internal sealed class RegisterCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {

        if (request.RePassword != request.Password)
        {
            return Result<string>.Failure("Password and password repeat do not match.");
        }

        AppUser? user = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            UserName = request.UserName
        };

        var result = await userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return Result<string>.Failure("Please ensure to use at least one upper case letter and one special character in password.");
        }

        return Result<string>.Succeed("User created successfully");

    }
}
