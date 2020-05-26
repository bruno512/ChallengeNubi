using ChallengeNubi.Core.Entities;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.Interfaces
{
    public interface ISearchBussiness
    {
        Task<Search> GetProduct(string id);
    }
}