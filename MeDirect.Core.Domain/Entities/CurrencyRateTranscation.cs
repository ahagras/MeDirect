namespace MeDirect.Core.Domain.Entities
{
    public class CurrencyRateTranscation
    {
        public required string CrrencyCode { get; set; }
        public required Guid RateId { get; set; }
        public required decimal Rate { get; set; }

        private CurrencyRateTranscation() { }
        public CurrencyRateTranscation(string crrencyCode, Guid rateId, decimal rate)
        {
            CrrencyCode = crrencyCode;
            RateId = rateId;
            Rate = rate;
        }

        public CurrencyRate? CurrencyRate { get; set; }

    }
}
