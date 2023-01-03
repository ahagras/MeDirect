using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirect.Core.Domain.Entities
{
    public class CurrencyRate
    {
        public Guid Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        public string RatedById { get; private set; }

        private CurrencyRate()
        {
            
        }

        public CurrencyRate(string ratedById, List<CurrencyRateTranscation> currencyRateTranscations) : this()
        {
            Id = Guid.NewGuid();
            CreateAt = DateTime.UtcNow;
            RatedById = ratedById;

            CurrencyRateTranscations = currencyRateTranscations;
        }

        public Currency? RatedBy { get; set; }
        public required ICollection<CurrencyRateTranscation> CurrencyRateTranscations { get; set; }

    }
}
