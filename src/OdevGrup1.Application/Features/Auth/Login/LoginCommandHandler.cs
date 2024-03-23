using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OdevGrup1.Domain.Entities;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Login;

internal sealed class LoginCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, Result<string>>
{
    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.Users.Where(u => u.Email == request.UserNameOrEmail || u.UserName == request.UserNameOrEmail).FirstOrDefaultAsync(cancellationToken);

        if (user is null)
        {
            return Result<string>.Failure("User not found!");
        }

        bool checkPassword = await userManager.CheckPasswordAsync(user, request.Password);
        if (!checkPassword)
        {
            throw new ArgumentException("Incorrect password!");
        }

        return Result<string>.Succeed("User login successful!");
    }
}
