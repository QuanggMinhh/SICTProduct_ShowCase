using Application.DTOs.RoleDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        // GET: api/role
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _roleService.GetAllRoleAsync();
            var roleDto = _mapper.Map<IEnumerable<RoleUpdateDto>>(roles);
            return Ok(roleDto);
        }

        // GET: api/role/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var role = await _roleService.GetRoleByIdAsync(id);
            if (role == null)
                return NotFound();
            return Ok(role);
        }


        // POST: api/role
        [HttpPost("add-role")]
        public async Task<IActionResult> CreateRole([FromBody] RoleCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var role = _mapper.Map<Role>(dto);
            await _roleService.AddRoleAsync(role);
            return Ok();
        }

        // PUT: api/role/{id}
        [HttpPut]
        public async Task<IActionResult> UpdateRole(RoleUpdateDto dto)
        {
            var existing = await _roleService.GetRoleByIdAsync(dto.Id);
            if (existing == null)
                return NotFound();

            var role = _mapper.Map<Role>(dto);
            await _roleService.UpdateRoleAsync(role);
            return Ok();
        }

        // DELETE: api/role/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = await _roleService.GetRoleByIdAsync(id);
            if (role == null)
                return NotFound();

            await _roleService.DeleteRoleAsync(id);
            return Ok();
        }
    }
}
