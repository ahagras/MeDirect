using MeDirect.Core.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirect.Core.Application
{
    public interface ICurrencyRateService
    {
        Task<CurrencyRateResponseModel> GetRates();
    }
}
