using ChallengeNubi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetCurrencies();

        Task<Ratio> GetRatioDolarByCurrency(string id);
    }
}