using FluentValidation;
using HealthMate.API.ViewModels.Nutrition;

namespace HealthMate.API.Validators
{
    public class ShortNutritionViewModelValidator : AbstractValidator<ShortNutritionViewModel>
    {
        public ShortNutritionViewModelValidator()
        {
            RuleFor(n => n.MealType)
                .NotEmpty()
                .NotNull()
                .Must(type => (int)type >= 0 && (int)type <= 4);

            RuleFor(h => h.Date)
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(new DateOnly(1900, 1, 1), DateOnly.FromDateTime(DateTime.UtcNow));

            RuleFor(h => h.UserId)
                .NotNull()
                .NotEmpty();

            RuleForEach(n => n.FoodItems)
                .SetValidator(new FoodItemViewModelValidator());

            RuleForEach(n => n.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
