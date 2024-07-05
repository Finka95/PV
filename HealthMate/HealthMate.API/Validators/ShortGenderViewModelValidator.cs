using FluentValidation;
using HealthMate.API.ViewModels.Gender;

namespace HealthMate.API.Validators
{
    public class ShortGenderViewModelValidator : AbstractValidator<ShortGenderViewModel>
    {
        public ShortGenderViewModelValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .NotNull()
                .Matches("^[a-zA-Z ]*$")
                .WithMessage("Gender name can only contain letters and spaces.")
                .MinimumLength(3)
                .MaximumLength(100)
                .Must(a => char.IsUpper(a[0]))
                .WithMessage("Gender name must start with an uppercase letter.");
        }
    }
}
