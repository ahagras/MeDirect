using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirect.Core.Domain.Entities
{
    public class Currency
    {
        public required string CurrencyCode { get; set; }
        public required string CurrencyName { get; set; }
        public required bool IsActive { get; set; }

        private Currency()
        {

        }
        public Currency(string currencyCode, string currencyName, bool isActive):this()
        {
            CurrencyName = currencyName;
            IsActive = isActive;
            CurrencyCode = currencyCode;
        }
    }
}
