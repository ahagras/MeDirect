using MeDirect.Core.Application;
using MeDirect.Core.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeDirect.Presentation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ILogger<CurrencyController> _logger;
        private readonly ICurrencyRateService currencyRateService;

        public CurrencyController(ILogger<CurrencyController> logger, ICurrencyRateService currencyRateService)
        {
            _logger = logger;
            this.currencyRateService = currencyRateService;
        }

        [HttpGet(Name = "GetCurrencyRates")]
        public async Task<ActionResult<CurrencyRateResponseModel>> GetCurrencyRates()
        {
            var response = await currencyRateService.GetRates();
            return Ok(response);
        }
    }
}