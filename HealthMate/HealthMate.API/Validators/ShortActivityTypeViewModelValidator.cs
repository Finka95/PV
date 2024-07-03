using FluentValidation;
using HealthMate.API.ViewModels.ActivityType;

namespace HealthMate.API.Validators
{
    public class ShortActivityTypeViewModelValidator : AbstractValidator<ShortActivityTypeViewModel>
    {
        public ShortActivityTypeViewModelValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .NotNull()
                .Matches("^[a-zA-Z ]*$")
                .WithMessage("Activity type name can only contain letters and spaces.")
                .MinimumLength(3)
                .MaximumLength(100)
                .Must(StartWithUppercase)
                .WithMessage("Activity type name must start with an uppercase letter.");
        }

        private bool StartWithUppercase(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            return char.IsUpper(name[0]);
        }
    }
}
