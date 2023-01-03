using MeDirect.Core.Domain;
using MeDirect.Core.Domain.Repositories;
using MeDirect.Infrastructure.Presistence;

namespace MeDirect.Inrastructure.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeDirectContext meDirectContext;

        public ICurrencyRepository Currencies { get; }
        public ICurrencyRateRepository CurrencyRates { get; }

        public UnitOfWork(MeDirectContext meDirectContext, ICurrencyRepository currencies, ICurrencyRateRepository currencyRates)
        {
            this.meDirectContext = meDirectContext;
            Currencies = currencies;
            CurrencyRates = currencyRates;
        }

        private bool _disposed = false;
        public async Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(this.GetType().FullName);
            }

            return await meDirectContext.SaveChangesAsync(cancellationToken);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing && meDirectContext != null)
            {
                meDirectContext.Dispose();
            }

            _disposed = true;
        }
    }
}
