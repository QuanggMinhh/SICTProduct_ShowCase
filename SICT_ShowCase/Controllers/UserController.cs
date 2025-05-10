using Application.DTOs.UserDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserByIdAsync(int id)
        {

            var user = await _userService.GetUserByIdAsync(id);
            var userDto = _mapper.Map<UserUpdateDto>(user);
            return Ok(userDto);
        }

        [HttpPost("them-moi")]
        public async Task<ActionResult> CreateUser(UserCreateDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userService.AddUserAsync(user);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllUserAsync()
        {
            var user = await _userService.GetAllUserAsync();
            var userDto = _mapper.Map<IEnumerable<UserUpdateDto>>(user);
            return Ok(userDto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            await _userService.DeleteUserAsync(user.Id);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(UserUpdateDto userDto)
        {

            var user = await _userService.GetUserByIdAsync(userDto.Id);
            if (user == null)
            {
                return BadRequest();
            }
            userDto.RoleId = user.RoleId;
            var updateUser = _mapper.Map<User>(userDto);
            await _userService.UpdateUserAsync(updateUser);
            return Ok();
        }
    }
}
