using MeDirect.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeDirect.Infrastructure.Presistence
{
    public class MeDirectContext : DbContext
    {

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        public DbSet<CurrencyRateTranscation> CurrencyRateTranscations { get; set; }

        public MeDirectContext(DbContextOptions<MeDirectContext> options)
      : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeDirectContext).Assembly);
        }
    }
}
