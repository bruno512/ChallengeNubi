using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNubi.Core.BusinessComponents
{
    public class UserBussiness : IUserBussiness
    {
        private readonly IUserRepository _userRepository;
        public UserBussiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _userRepository.GetUser(id);
            return user;
        }

        public async Task InsertUser(User user)
        {
            await _userRepository.InsertUser(user);
        }

        public async Task<bool> UpdateUser(User user)
        {
            var result = await _userRepository.UpdateUser(user);
            return result;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var result = await _userRepository.DeleteUser(id);
            return result;
        }
    }
}
