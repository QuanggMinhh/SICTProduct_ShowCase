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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }
        public async Task AddUserAsync(User user)
        {
            user.RoleId = await _ShowCaseContext.Roles.Where(x => x.RoleName == "Contributor").Select(x => x.Id).FirstOrDefaultAsync();
            await _ShowCaseContext.AddAsync(user);

        }
        public async Task<User> FindByIdAsync(int id)
        {
            return await _ShowCaseContext.Users.Include(x => x.Role).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
