using ChallengeNubi.Api.Responses;
using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChallengeNubi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchBussiness _searchBussiness;
        public SearchController(ISearchBussiness searchBussiness)
        {
            _searchBussiness = searchBussiness;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(string id)
        {
            var country = await _searchBussiness.GetProduct(id);

            return Ok(new BaseResponse<Search>(country));
        }
    }
}
