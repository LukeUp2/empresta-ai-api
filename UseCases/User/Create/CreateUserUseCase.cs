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
            //mapear para uma entidade
            //preciso hashar a senha
            //criar o identificador do usuário? acho que nao precisa
            //chamar o repo para salvar no db
            //retornar o nome e, no futuro, retornar o token JWT
        }


        private void Validate(CreateUserRequest request)
        {
            var result = new CreateUserUseCaseValidator().Validate(request);

            //TODO - Verificar se email ja existe na base

            if (result.IsValid.IsFalse())
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).ToList());
            }
        }
    }
}