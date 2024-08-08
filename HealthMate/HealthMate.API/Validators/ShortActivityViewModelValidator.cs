using FluentValidation;
using HealthMate.API.ViewModels.Activity;
using System.Text.RegularExpressions;

namespace HealthMate.API.Validators
{
    public class ShortActivityViewModelValidator : AbstractValidator<ShortActivityViewModel>
    {
        public ShortActivityViewModelValidator()
        {
            RuleFor(a => a.Date)
                .NotNull()
                .NotEmpty()
                .Must(m => Regex.IsMatch(m.Date.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"),
                    @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}\.\d{3}[+-]\d{2}:\d{2}$"))
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.UtcNow.Date.AddDays(1).AddTicks(-1))
                .WithMessage("Date must be in the format 'yyyy-MM-ddTHH:mm:ss.fffzzz' and between 1900-01-01 and the end of the current UTC day"); ;

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
