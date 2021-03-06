﻿using ChallengeNubi.Core.Entities;
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
        private readonly ChallengeNubiContext _context;
        public UserRepository(ChallengeNubiContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.User.ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.User.FirstOrDefaultAsync(x => x.UserId == id);
            return user;
        }

        public async Task InsertUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateUser(User user)
        {
            int rows = 0;
            var currentUser = await GetUser(user.UserId);
            if (currentUser != null)
            {
                currentUser.FirstName = user.FirstName;
                currentUser.LastName = user.LastName;
                currentUser.Email = user.Email;
                currentUser.Password = user.Password;

                rows = await _context.SaveChangesAsync();
            }            
            return rows > 0;
        }

        public async Task<bool> DeleteUser(int id)
        {
            int rows = 0;
            var currentUser = await GetUser(id);
            if (currentUser != null)
            {
                _context.User.Remove(currentUser);
                rows = await _context.SaveChangesAsync();
            }            
            return rows > 0;
        }
    }
}
