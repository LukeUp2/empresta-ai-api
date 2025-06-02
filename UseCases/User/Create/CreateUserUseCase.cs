using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Exceptions;
using api.Extensions;
using api.Repositories;
using api.Requests;
using api.Responses;
using api.Services;
using api.Services.Maps.User;
using FluentValidation.Results;

namespace api.UseCases.User.Create
{
    public class CreateUserUseCase
    {
        private readonly PasswordEncrypter _passwordEncrypter;
        private readonly UserRepository _userRepository;
        private readonly UnitOfWork _unitOfWork;

        public CreateUserUseCase(PasswordEncrypter passwordEncrypter, UserRepository userRepository, UnitOfWork unitOfWork)
        {
            _passwordEncrypter = passwordEncrypter;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseUserCreated> Execute(CreateUserRequest request)
        {
            Validate(request);
            //mapear para uma entidade
            var user = request.ToEntity();
            //preciso hashar a senha
            var hashedPassword = _passwordEncrypter.Encrypt(request.Password);
            user.HashedPassword = hashedPassword;
            //chamar o repo para salvar no db
            await _userRepository.Add(user);
            await _unitOfWork.Commit();
            //retornar o nome e, no futuro, retornar o token JWT
            return new ResponseUserCreated
            {
                Name = user.Name
            };
        }


        private void Validate(CreateUserRequest request)
        {
            var result = new CreateUserUseCaseValidator().Validate(request);

            var emailAlreadyExists = _userRepository.CheckIfEmailAlreadyExists(request.Email);

            if (emailAlreadyExists)
            {
                result.Errors.Add(new ValidationFailure(string.Empty, "Email is already in use."));
            }

            if (result.IsValid.IsFalse())
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).ToList());
            }
        }
    }
}