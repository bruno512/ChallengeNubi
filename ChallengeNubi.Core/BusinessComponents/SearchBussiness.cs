using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.BusinessComponents
{
    public class SearchBussiness : ISearchBussiness
    {
        private readonly ISearchRepository _searchRepository;
        public SearchBussiness(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }
        public async Task<Search> GetProduct(string id)
        {
            //var resultFull = await _searchRepository.GetProduct(id);



            return await _searchRepository.GetProduct(id);
        }
    }
}
