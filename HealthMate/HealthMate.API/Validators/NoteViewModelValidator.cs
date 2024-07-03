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
                .InclusiveBetween(new DateOnly(1900, 1, 1), DateOnly.FromDateTime(DateTime.Now));

            RuleFor(n => n.Content)
                .NotEmpty()
                .NotNull()
                .MaximumLength(10000);
        }
    }
}
