using Microsoft.AspNetCore.Identity;
using OdevGrup1.Domain.Entities;

namespace OdevGrup1.WebAPI.Middlewares;

public static class ExtensionsMiddleware
{
    public static void CreateFirstUserAsync(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            if (!userManager.Users.Any(u => u.UserName == "admin"))
            {
                AppUser user = new()
                {
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Cuma",
                    LastName = "KÖSE",
                    EmailConfirmed = true
                };

                userManager.CreateAsync(user, "String1*").Wait();
            }
        }
    }
}
