using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace api.DependencyInjection
{
    public static class ApplicationExtensions
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddUseCases(services);
            AddDbContext(services, configuration);
            AddRepositories(services);
        }

        private static void AddUseCases(IServiceCollection services)
        {

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
    }
}