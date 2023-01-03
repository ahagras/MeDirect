using MeDirect.Core.Domain.Entities;
using MeDirect.Core.Domain.Repositories;
using MeDirect.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace MeDirect.Inrastructure.Presistence.Repositories
{
    public class CurrencyRateRepository : Repository<CurrencyRate>, ICurrencyRateRepository
    {
        public CurrencyRateRepository(MeDirectContext dbContext) : base(dbContext)
        {
        }

        public async Task<CurrencyRate> GetAllAsync()
        => await dbContext.CurrencyRates.Include(_ => _.CurrencyRateTranscations)
            .OrderByDescending(_ => _.CreateAt)
            .FirstAsync();
    }
}
