using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Enumerations;
using ChallengeNubi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
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
            if (id == Constants.Country.Brasil || id == Constants.Country.Colombia)
            {
                throw new Exception("Pais no permitido");
            }
            return await _countryRepository.GetCountry(id);
        }
    }
}
