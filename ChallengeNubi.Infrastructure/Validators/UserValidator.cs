using ChallengeNubi.Core.DTOs;
using FluentValidation;

namespace ChallengeNubi.Infrastructure.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName)
                .NotNull()
                .Length(1, 50);

            RuleFor(user => user.LastName)
                .NotNull()
                .Length(1, 50);

            RuleFor(user => user.Email)
               .NotNull()
               .Length(1, 30);

            RuleFor(user => user.Password)
               .NotNull()
               .Length(1, 10);
        }
    }
}
