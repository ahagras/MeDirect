using MeDirect.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeDirect.Inrastructure.Presistence.Configuration
{
    public class CurrencyRateTranscationConfiguration : IEntityTypeConfiguration<CurrencyRateTranscation>
    {
        public void Configure(EntityTypeBuilder<CurrencyRateTranscation> builder)
        {
            builder.HasKey(_ => new {_.RateId,_.CrrencyCode });

            builder.HasOne(_ => _.CurrencyRate)
                .WithMany(_ => _.CurrencyRateTranscations)
                .HasForeignKey(_ => _.RateId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
