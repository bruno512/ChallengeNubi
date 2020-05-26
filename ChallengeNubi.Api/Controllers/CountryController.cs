using ChallengeNubi.Api.Responses;
using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChallengeNubi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryBussiness _countryBussiness;
        public CountryController(ICountryBussiness countryBussiness)
        {
            _countryBussiness = countryBussiness;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountry(string id)
        {
            var country = await _countryBussiness.GetCountry(id);
            
            return Ok(new BaseResponse<Country>(country));
        }
    }
}
