using FluentValidation;

namespace OdevGrup1.Application.Features.Auth.Register;

internal sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(u => u.UserName).NotNull().NotEmpty().WithMessage("UserName cannot be null");
        RuleFor(p => p.UserName).NotNull().WithMessage("UserName cannot be null");
        RuleFor(p => p.UserName).MinimumLength(3).WithMessage("UserName has to contain more than 3 character");
        RuleFor(u => u.Email).NotNull().NotEmpty().WithMessage("Email cannot be null");
        RuleFor(p => p.Email).NotNull().WithMessage("Email cannot be null");
        RuleFor(p => p.Email).MinimumLength(3).WithMessage("Email has to contain more than 6 character");
        RuleFor(p => p.Password).NotEmpty().WithMessage("Password cannot be null");
        RuleFor(p => p.Password).NotNull().WithMessage("Password cannot be null");
        RuleFor(p => p.Password).MinimumLength(6).WithMessage("Password has to contain more than 6 character");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Password has to contain at least 1 uppercase character");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Password has to contain at least 1 lowercase character");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Password has to contain at least 1 number");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Password has to contain at least 1 special character");
    }
}