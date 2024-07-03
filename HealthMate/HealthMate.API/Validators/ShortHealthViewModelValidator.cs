using FluentValidation;
using HealthMate.API.ViewModels.Health;

namespace HealthMate.API.Validators
{
    public class ShortHealthViewModelValidator : AbstractValidator<ShortHealthViewModel>
    {
        public ShortHealthViewModelValidator()
        {
            RuleFor(h => h.Date)
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(new DateOnly(1900, 1, 1), DateOnly.FromDateTime(DateTime.Now));

            RuleFor(h => h.UserId)
                .NotNull()
                .NotEmpty();

            RuleFor(h => h.HeartRate)
                .InclusiveBetween(40, 120);

            RuleFor(h => h.BloodSugar)
                .InclusiveBetween(3.9, 7.8);

            RuleFor(h => h.Cholesterol)
                .InclusiveBetween(3.0, 6.0);

            RuleFor(h => h.SystolicBloodPressure)
                .InclusiveBetween(90, 180);

            RuleFor(h => h.DiastolicBloodPressure)
                .InclusiveBetween(60, 120);

            RuleForEach(h => h.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
