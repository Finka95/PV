using FluentValidation;
using HealthMate.API.ViewModels.User;

namespace HealthMate.API.Validators
{
    public class ShortUserViewModelValidator : AbstractValidator<ShortUserViewModel>
    {
        public ShortUserViewModelValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .NotNull()
                .Length(4, 50);

            RuleFor(u => u.UserName)
                .NotEmpty()
                .NotNull()
                .Length(4, 50)
                .Matches("^[a-zA-Z0-9]*$");

            RuleFor(u => u.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(u => u.Weight)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0, 500);

            RuleFor(u => u.Height)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(0, 300);

            RuleFor(u => u.GenderId)
                .NotEmpty()
                .NotNull();

            RuleFor(u => u.DateOfBirth)
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(new DateOnly(1900, 1, 1), DateOnly.FromDateTime(DateTime.Now));
        }
    }
}
