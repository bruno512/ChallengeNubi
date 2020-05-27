using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Enumerations;
using ChallengeNubi.Core.Exceptions;
using ChallengeNubi.Core.Interfaces;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.BusinessComponents
{
    public class CountryBussiness : ICountryBussiness
    {
        private readonly ICountryRepository _countryRepository;

        public CountryBussiness(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<Country> GetCountry(string id)
        {
            if (id == Constants.Country.Argentina)
            {
                return await _countryRepository.GetCountry(id);
            }
            else
            {
                throw new BusinessException("Country not allowed.");
            }            
        }
    }
}
