using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Requests;
using FluentValidation;

namespace api.UseCases.User.Create
{
    public class CreateUserUseCaseValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserUseCaseValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The name is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("The email is invalid");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("The passord must have at least 6 characters");
        }
    }
}