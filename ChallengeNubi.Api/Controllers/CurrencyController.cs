using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeNubi.Api.Responses;
using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeNubi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyBussiness _currencyBussiness;
        public CurrencyController(ICurrencyBussiness currencyBussiness)
        {
            _currencyBussiness = currencyBussiness;
        }
        /// <summary>
        /// Generate and save to disk a json and csv file with monetary information
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCurrencies()
        {
            var result = await _currencyBussiness.GetCurrencies();

            return Ok(new BaseResponse<BaseEntity>(result));
        }
    }
}
