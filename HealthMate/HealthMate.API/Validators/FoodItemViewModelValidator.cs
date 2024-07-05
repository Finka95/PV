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
                .Must(f => char.IsUpper(f[0]))
                .WithMessage("Food name must start with an uppercase letter.");

            RuleFor(f => f.Carbohydrates)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0.0, 100.0);

            RuleFor(f => f.Fat)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0.0, 100.0);

            RuleFor(f => f.Protein)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0.0, 100.0);

            RuleFor(f => f.Quantity)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0.0, 30000.0);
        }
    }
}
