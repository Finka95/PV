using FluentValidation;
using HealthMate.API.ViewModels.Mood;
using HealthMate.DAL.Enums;

namespace HealthMate.API.Validators
{
    public class ShortMoodViewModelValidator : AbstractValidator<ShortMoodViewModel>
    {
        public ShortMoodViewModelValidator()
        {
            RuleFor(m => m.StressLevel)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0, 10);

            RuleFor(m => m.MoodStatus)
                .NotEmpty()
                .NotNull()
                .Must(status => (int)status >= 0 && (int)status <= 10);

            RuleFor(h => h.Date)
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(new DateOnly(1900, 1, 1), DateOnly.FromDateTime(DateTime.UtcNow));

            RuleFor(h => h.UserId)
                .NotNull()
                .NotEmpty();

            RuleForEach(m => m.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
