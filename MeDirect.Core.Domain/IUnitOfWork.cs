using MeDirect.Core.Domain.Repositories;

namespace MeDirect.Core.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        public ICurrencyRepository Currencies { get; }
        public ICurrencyRateRepository CurrencyRates { get; }

        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
