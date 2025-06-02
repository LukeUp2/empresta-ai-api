using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Repositories;
using api.Services;
using api.UseCases.User.Create;
using Microsoft.EntityFrameworkCore;

namespace api.DependencyInjection
{
    public static class ApplicationExtensions
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddUseCases(services);
            AddDbContext(services, configuration);
            AddPasswordEncrypter(services, configuration);
            AddRepositories(services);
            AddUnitOfWork(services);
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<CreateUserUseCase>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<UserRepository>();
            services.AddScoped<LoanRepository>();
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmprestaAiDbContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        private static void AddUnitOfWork(IServiceCollection services)
        {
            services.AddScoped<UnitOfWork>();
        }

        private static void AddPasswordEncrypter(IServiceCollection services, IConfiguration configuration)
        {
            var additionalKey = configuration.GetValue<string>("Configuration:PasswordAdditionalKey");
            services.AddScoped(opt => new PasswordEncrypter(additionalKey!));
        }


    }
}