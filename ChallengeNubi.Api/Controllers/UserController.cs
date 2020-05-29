using AutoMapper;
using ChallengeNubi.Api.Responses;
using ChallengeNubi.Core.DTOs;
using ChallengeNubi.Core.Entities;
using ChallengeNubi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);

            return Ok(new BaseResponse<IEnumerable<UserDto>>(usersDto));
        }

        /// <summary>
        /// Get a specified user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userRepository.GetUser(id);
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(new BaseResponse<UserDto>(userDto));
        }

        /// <summary>
        /// Insert user
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> InsertUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.InsertUser(user);
            userDto = _mapper.Map<UserDto>(user);
            return Created("uri", new BaseResponse<UserDto>(userDto));
        }

        /// <summary>
        /// Update a specified user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.UserId = id;
            var result = await _userRepository.UpdateUser(user);
            return Ok(new BaseResponse<bool>(result));
        }

        /// <summary>
        /// Delete a especified user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userRepository.DeleteUser(id);
            return Ok(new BaseResponse<bool>(result));
        }
    }
}
