using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using ChallengeNubi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNubi.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ChallengeNubiContext _challengeNubiContext;
        public UserRepository(ChallengeNubiContext challengeNubiContext)
        {
            _challengeNubiContext = challengeNubiContext;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _challengeNubiContext.User.ToListAsync();
            return users;
        }
    }
}
