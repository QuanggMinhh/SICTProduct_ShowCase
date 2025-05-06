using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAllRoleAsync();
        Task<Role> GetRoleByIdAsync(int id);
        //Task<PageResultDto<UserDto>> GetUserPageAsync(int page, int pageSize);
        Task AddRoleAsync(Role role);
        Task DeleteRoleAsync(int id);
        Task UpdateRoleAsync(Role role);

    }
}
