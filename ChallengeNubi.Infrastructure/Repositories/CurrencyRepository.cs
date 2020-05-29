using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Enumerations;
using ChallengeNubi.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChallengeNubi.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri(Constants.BaseAdress.MercadoLibre);

            var request = await httpClient.GetAsync(Constants.Currency.RequestCurrencies);

            if (request.IsSuccessStatusCode)
            {
                var resultJson = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<IEnumerable<Currency>>(resultJson);
                return result;
            }
            return new List<Currency>();
        }

        public async Task<Ratio> GetRatioDolarByCurrency(string id)
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri(Constants.BaseAdress.MercadoLibre);

            var request = await httpClient.GetAsync(string.Format(Constants.Currency.RequestCurrency_Conversions, id) );
            if (request.IsSuccessStatusCode)
            {
                var resultJson = request.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Ratio>(resultJson);                
            }
            return new Ratio();
        }
    }
}
