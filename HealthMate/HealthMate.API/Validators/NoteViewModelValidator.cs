using FluentValidation;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.Validators
{
    public class NoteViewModelValidator : AbstractValidator<NoteViewModel>
    {
        public NoteViewModelValidator()
        {
            RuleFor(n => n.Date)
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(new DateTime(1900, 1, 1), DateTime.UtcNow);

            RuleFor(n => n.Content)
                .NotEmpty()
                .NotNull()
                .MaximumLength(10000);
        }
    }
}
