using FluentValidation;
using HealthMate.API.ViewModels.Activity;

namespace HealthMate.API.Validators
{
    public class ShortActivityViewModelValidator : AbstractValidator<ShortActivityViewModel>
    {
        public ShortActivityViewModelValidator()
        {
            RuleFor(a => a.Date)
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.UtcNow)
                .NotNull()
                .NotEmpty();

            RuleFor(a => a.CaloriesBurned)
                .InclusiveBetween(0, int.MaxValue)
                .NotNull()
                .NotEmpty();

            RuleFor(a => a.Duration)
                .InclusiveBetween(TimeSpan.Zero, TimeSpan.MaxValue)
                .NotNull()
                .NotEmpty();

            RuleFor(a => a.UserId)
                .NotNull()
                .NotEmpty();

            RuleFor(a => a.ActivityTypeId)
                .NotNull()
                .NotEmpty();

            RuleForEach(a => a.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
