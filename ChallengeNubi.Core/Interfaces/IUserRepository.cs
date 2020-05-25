using ChallengeNubi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);

        Task InsertUser(User user);

        Task<bool> UpdateUser(User user);

        Task<bool> DeleteUser(int id);
    }
}
