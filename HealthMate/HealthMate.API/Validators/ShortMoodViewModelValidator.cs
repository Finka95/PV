using FluentValidation;
using HealthMate.API.ViewModels.Mood;
using System.Text.RegularExpressions;

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
                .Must(m => Regex.IsMatch(m.Date.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"),
                    @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}\.\d{3}[+-]\d{2}:\d{2}$"))
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.UtcNow.Date.AddDays(1).AddTicks(-1))
                .WithMessage("Date must be in the format 'yyyy-MM-ddTHH:mm:ss.fffzzz' and between 1900-01-01 and the end of the current UTC day"); ;

            RuleFor(h => h.UserId)
                .NotNull()
                .NotEmpty();

            RuleForEach(m => m.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
