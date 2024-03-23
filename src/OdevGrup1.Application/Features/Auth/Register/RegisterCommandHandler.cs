using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using OdevGrup1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace OdevGrup1.Application.Features.Auth.Register;
internal sealed class RegisterCommandHandler(UserManager<AppUser> userManager, IMapper mapper) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        AppUser user = mapper.Map<AppUser>(request);

        var result = await userManager.CreateAsync(user);

        if (!result.Succeeded)
        {
            string errorMessage = string.Join(", ", result.Errors.Select(error => error.Description));
            return "Kullanıcı kaydı sırasında hata oluştu: " + errorMessage;
        }

        return "Kullanıcı başarıyla kaydedildi.";

    }
}
