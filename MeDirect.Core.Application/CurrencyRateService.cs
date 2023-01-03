using MeDirect.Core.Application.Models;
using MeDirect.Core.Domain;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace MeDirect.Core.Application
{
    public class CurrencyRateService : ICurrencyRateService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache memoryCache;

        public CurrencyRateService(IUnitOfWork unitOfWork, IMemoryCache memoryCache)
        {
            this.unitOfWork = unitOfWork;
            this.memoryCache = memoryCache;
        }
        public async Task<CurrencyRateResponseModel> GetRates()
        {
            // will use distuted or in memory cache - but no time to handle it


            var res = await unitOfWork.CurrencyRates.GetAllAsync();

            return res.ToCurrencyRate();
        }
    }
}
