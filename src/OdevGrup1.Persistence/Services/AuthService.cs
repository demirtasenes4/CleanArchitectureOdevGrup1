using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OdevGrup1.Application.Features.Auth.Register;
using OdevGrup1.Application.Services;
using OdevGrup1.Domain.Entities;
using TS.Result;

namespace OdevGrup1.Persistence.Services;
public sealed class AuthService(UserManager<AppUser> userManager, IMapper mapper) : IAuthService
{
    public async Task<Result<string>> CreateAsync(RegisterCommand request, CancellationToken cancellationToken)
    {
        if (request.Email is not null)
        {
            var isEmailExists = await userManager.Users.AnyAsync(u => u.Email == request.Email);
            if (isEmailExists)
            {
                return Result<string>.Failure(StatusCodes.Status409Conflict, "Email already has taken");
            }
        }

        if (request.UserName is not null)
        {
            var isUserNameExists = await userManager.Users.AnyAsync(u => u.UserName == request.UserName);
            if (isUserNameExists)
            {
                return Result<string>.Failure(StatusCodes.Status409Conflict, "UserName already has taken");
            }
        }

        var user = mapper.Map<AppUser>(request);
        int number = 1;
        while (await userManager.Users.AnyAsync(u => u.UserName == user.UserName))
        {
            number++;
            user.UserName += number;
        }
        

        IdentityResult result;
        if (request.Password is not null)
        {
            result = await userManager.CreateAsync(user, request.Password);
        }
        else
        {
            result = await userManager.CreateAsync(user);
        }

        if (result.Succeeded)
        {
            return Result<string>.Succeed("User create is successfull");
        }

        return Result<string>.Failure(500, result.Errors.Select(s => s.Description).ToList());
    }
}
