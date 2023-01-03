
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace MeDirect.Core.Application
{
    public static class DIContatiner
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddScoped<ICurrencyRateService, CurrencyRateService>();
            return services;
        }
    }
}
