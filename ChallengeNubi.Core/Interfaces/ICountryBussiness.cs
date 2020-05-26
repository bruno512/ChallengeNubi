using ChallengeNubi.Core.Entities;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.Interfaces
{
    public interface ICountryBussiness
    {
        Task<Country> GetCountry(string id);
    }
}