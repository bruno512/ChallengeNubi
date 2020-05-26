﻿using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNubi.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public async Task<Country> GetCountry(string id)
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://api.mercadolibre.com/");

            var request = await httpClient.GetAsync("classified_locations/countries/" + id);

            if (request.IsSuccessStatusCode)
            {
                var resultJson = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<Country>(resultJson);
                return result;
            }
            return new Country();
        }
    }
}