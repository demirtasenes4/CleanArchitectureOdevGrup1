using FluentValidation;

namespace OdevGrup1.Application.Features.Auth.Login;

public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(p => p.UserNameOrEmail).NotEmpty().WithMessage("UserName cannot be null");
        RuleFor(p => p.UserNameOrEmail).NotNull().WithMessage("UserName cannot be null");
        RuleFor(p => p.UserNameOrEmail).MinimumLength(3).WithMessage("Has to contain more than 3 character");
        RuleFor(p => p.Password).NotEmpty().WithMessage("Password cannot be null");
        RuleFor(p => p.Password).NotNull().WithMessage("Password cannot be null");
        RuleFor(p => p.Password).MinimumLength(6).WithMessage("Password has to contain more than 6 character");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Password has to contain at least 1 uppercase character");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Password has to contain at least 1 lowercase character");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Password has to contain at least 1 number");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Password has to contain at least 1 special character");
    }
}