using FluentValidation;
using HealthMate.API.ViewModels.Medication;

namespace HealthMate.API.Validators
{
    public class ShortMedicationViewModelValidator : AbstractValidator<ShortMedicationViewModel>
    {
        public ShortMedicationViewModelValidator()
        {
            RuleFor(m => m.Date)
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.UtcNow);

            RuleFor(m => m.UserId)
                .NotNull()
                .NotEmpty();

            RuleFor(m => m.MedicationName)
                .NotEmpty()
                .NotNull()
                .Matches("^[a-zA-Z ]*$")
                .WithMessage("Gender name can only contain letters and spaces.")
                .MinimumLength(3)
                .MaximumLength(150);

            RuleFor(m => m.Dosage)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(m => m.Frequency)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(200);

            RuleFor(m => m)
                .Must(m => m.StartDate < m.EndDate)
                .When(m => m.StartDate > new DateTime(1900, 1, 1) &&
                           m.StartDate < DateTime.MaxValue)
                .When(m => m.EndDate > new DateTime(1900, 1, 1) &&
                           m.EndDate < DateTime.MaxValue);

            RuleForEach(m => m.Notes)
                .SetValidator(new NoteViewModelValidator());
        }
    }
}
