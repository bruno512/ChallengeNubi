using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Enumerations;
using ChallengeNubi.Core.Exceptions;
using ChallengeNubi.Core.Interfaces;
using Nancy.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.BusinessComponents
{
    public class CurrencyBussiness : ICurrencyBussiness
    {
        private readonly ICurrencyRepository _currencyRepository;
        public CurrencyBussiness(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        /// <summary>
        /// Get available currencies and with the key of each currency the ratio is obtained, then create and save the json and CSV files on disk
        /// </summary>
        /// <returns></returns>
        public async Task<BaseEntity> GetCurrencies()
        {
            var result = new BaseEntity { OperationResult = false, MessageResult = Constants.Errors.ErrorEmpty };
            
            var currencies = await _currencyRepository.GetCurrencies();
            if (currencies != null && currencies.Count() > 0)
            {
                var ratios = new StringBuilder();
                ratios.AppendLine("Ratio");
                foreach (Currency currency in currencies)
                {
                    var output = await _currencyRepository.GetRatioDolarByCurrency(currency.id);
                    currency.toDolar = output.ratio;
                    ratios.AppendLine(output.ratio.ToString());
                }
                // create and save the json and CSV
                string currenciesJson = new JavaScriptSerializer().Serialize(currencies);
                var path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\Resources";
                if (!Directory.Exists(path))                
                    Directory.CreateDirectory(path);
                
                string fileJson = "currencies_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + ".txt";
                var fileCsv = "ratios_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + ".csv";
                File.WriteAllText(Path.Combine(path, fileJson), currenciesJson);
                File.WriteAllText(Path.Combine(path, fileCsv), ratios.ToString());

                result.OperationResult = true;
                result.MessageResult = string.Format(Constants.Currency.MessageSuccess, path);
            }            
            return result;           
        }
    }
}
