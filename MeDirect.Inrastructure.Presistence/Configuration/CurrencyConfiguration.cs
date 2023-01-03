using MeDirect.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeDirect.Inrastructure.Presistence.Configuration
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(_ => _.CurrencyCode);

            builder.Property(_ => _.CurrencyName)
                .HasMaxLength(50);
        }
    }
}
