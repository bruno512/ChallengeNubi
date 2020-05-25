using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChallengeNubi.Core.DTOs;
using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeNubi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userRepository.GetUser(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> InsertUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.InsertUser(user);
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.UserId = id;
            await _userRepository.UpdateUser(user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userRepository.DeleteUser(id);
            return Ok(result);
        }
    }
}
