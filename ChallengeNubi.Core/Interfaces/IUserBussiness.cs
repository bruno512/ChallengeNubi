using ChallengeNubi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.BusinessComponents
{
    public interface IUserBussiness
    {
        Task<bool> DeleteUser(int id);
        Task<User> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
        Task InsertUser(User user);
        Task<bool> UpdateUser(User user);
    }
}