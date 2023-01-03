using MeDirect.Core.Domain.Entities;

namespace MeDirect.Core.Domain.Repositories
{
    public interface ICurrencyRateRepository : IRepository<CurrencyRate>
    {
        Task<CurrencyRate> GetAllAsync();
    }
}
