using ChallengeNubi.Core.Entities;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.Interfaces
{
    public interface ICurrencyBussiness
    {
        Task<BaseEntity> GetCurrencies();
    }
}