using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementation
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _ShowCaseContext.Roles.ToListAsync();
        }
    }
}
