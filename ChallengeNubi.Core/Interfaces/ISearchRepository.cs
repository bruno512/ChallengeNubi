using ChallengeNubi.Core.Entities;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.Interfaces
{
    public interface ISearchRepository
    {
        Task<Search> GetProduct(string id);
    }
}