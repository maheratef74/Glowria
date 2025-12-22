using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Glowria.Application.Commands.Register;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator(IStringLocalizer<RegisterRequestValidator> localizer)
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(localizer["Email is required"])
            .EmailAddress().WithMessage(localizer["Invalid email address"]);

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage(localizer["Password is required"])
            .MinimumLength(8).WithMessage(localizer["Password must be at least 8 characters"])
            .Matches("[A-Z]").WithMessage(localizer["Password must contain an uppercase letter"])
            .Matches("[a-z]").WithMessage(localizer["Password must contain a lowercase letter"])
            .Matches("[0-9]").WithMessage(localizer["Password must contain a number"]);

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(localizer["Name is required"])
            .MinimumLength(3).WithMessage(localizer["Name must be at least 3 characters"]);
    }
}