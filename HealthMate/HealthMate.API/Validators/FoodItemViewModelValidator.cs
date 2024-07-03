using FluentValidation;
using HealthMate.API.ViewModels.FoodItem;

namespace HealthMate.API.Validators
{
    public class FoodItemViewModelValidator : AbstractValidator<FoodItemViewModel>
    {
        public FoodItemViewModelValidator()
        {
            RuleFor(f => f.Name)
                .NotEmpty()
                .NotNull()
                .Matches("^[a-zA-Z ]*$")
                .WithMessage("Food name can only contain letters and spaces.")
                .MinimumLength(3)
                .MaximumLength(100)
                .Must(StartWithUppercase)
                .WithMessage("Food name must start with an uppercase letter.");

            RuleFor(f => f.Carbohydrates)
                .InclusiveBetween(0.0, 100.0)
                .NotEmpty()
                .NotNull();

            RuleFor(f => f.Fat)
                .InclusiveBetween(0.0, 100.0)
                .NotEmpty()
                .NotNull();

            RuleFor(f => f.Protein)
                .InclusiveBetween(0.0, 100.0)
                .NotEmpty()
                .NotNull();

            RuleFor(f => f.Quantity)
                .InclusiveBetween(0.0, 30000.0)
                .NotEmpty()
                .NotNull();
        }

        private bool StartWithUppercase(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            return char.IsUpper(name[0]);
        }
    }
}
