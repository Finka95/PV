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
                .InclusiveBetween(new DateOnly(1900, 1, 1), DateOnly.FromDateTime(DateTime.UtcNow));

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
