using MeDirect.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirect.Core.Application.Models
{
    public static class MapperExtensions
    {
        public static CurrencyRateResponseModel ToCurrencyRate(this CurrencyRate currencyRate)
            => new CurrencyRateResponseModel
            {
                RateBy = currencyRate.RatedById,
                Rates = currencyRate.CurrencyRateTranscations.Select(r => new CurrencyRatesModel
                {
                    Currency = r.CrrencyCode,
                    Rate = r.Rate,
                }).ToList(),
            };
    }
}
