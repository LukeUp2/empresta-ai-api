using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Exceptions;
using api.Extensions;
using api.Requests;

namespace api.UseCases.User.Create
{
    public class CreateUserUseCase
    {

        public void Execute(CreateUserRequest request)
        {
            Validate(request);
        }


        private void Validate(CreateUserRequest request)
        {
            var result = new CreateUserUseCaseValidator().Validate(request);

            if (result.IsValid.IsFalse())
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).ToList());
            }
        }
    }
}