﻿using FluentValidation;

namespace OdevGrup1.Application.Features.Auth.Register;

internal sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(u => u.Username).NotNull().NotEmpty().WithMessage("UserName not null");
    }
}