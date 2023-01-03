using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirect.Core.Application.Models
{
    public record CurrencyRateResponseModel
    {
        public string RateBy { get; set; }
        public IList<CurrencyRatesModel> Rates { get; set; }

    }

    public record CurrencyRatesModel
    {
        public string Currency { get; set; }
        public decimal Rate { get; set; }
    }

}
