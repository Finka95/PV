using FluentValidation;
using HealthMate.API.ViewModels.Health;
using System.Text.RegularExpressions;

namespace HealthMate.API.Validators
{
    public class ShortHealthViewModelValidator : AbstractValidator<ShortHealthViewModel>
    {
        public ShortHealthViewModelValidator()
        {
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

            RuleFor(h => h.HeartRate)
                .InclusiveBetween(20, 140);

            RuleFor(h => h.BloodSugar)
                .InclusiveBetween(2.0, 15.0);

            RuleFor(h => h.Cholesterol)
                .InclusiveBetween(1.5, 10.0);

            RuleFor(h => h.SystolicBloodPressure)
                .InclusiveBetween(40, 350);

            RuleFor(h => h.DiastolicBloodPressure)
                .InclusiveBetween(40, 350);

            RuleForEach(h => h.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
