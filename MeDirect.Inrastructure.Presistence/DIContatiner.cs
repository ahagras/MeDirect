using MeDirect.Core.Domain;
using MeDirect.Core.Domain.Repositories;
using MeDirect.Inrastructure.Presistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MeDirect.Inrastructure.Presistence
{
    public static class DIContatiner
    {
        public static IServiceCollection AddPresistence(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<ICurrencyRateRepository, CurrencyRateRepository>();

            return services;
        }
    }
}