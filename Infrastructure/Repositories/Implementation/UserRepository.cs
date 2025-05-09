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
            // Lấy roleId của Manager (RoleId = 2 là Manager)
            var managerRoleId = await _ShowCaseContext.Roles
                .Where(r => r.RoleName == "Manager")
                .Select(r => r.Id)
                .FirstOrDefaultAsync();

            if (managerRoleId == 0)
            {
                throw new Exception("Role 'Manager' not found.");
            }

            user.RoleId = managerRoleId;

            // Đặt trạng thái mặc định cho người dùng nếu cần
            user.Status = 1; //1 là trạng thái "Hoạt động"

            // Thêm người dùng vào cơ sở dữ liệu
            await _ShowCaseContext.Users.AddAsync(user);

        }
        public async Task<User> FindByIdAsync(int id)
        {
            // Kiểm tra nếu id không hợp lệ
            if (id <= 0)
            {
                throw new ArgumentException("Invalid user id", nameof(id));
            }

            // Tìm kiếm người dùng theo id và kèm theo Role
            var user = await _ShowCaseContext.Users
                .Include(x => x.Role) // Bao gồm mối quan hệ với Role
                .FirstOrDefaultAsync(x => x.Id == id);

            // Kiểm tra nếu người dùng không tồn tại
            if (user == null)
            {
                throw new KeyNotFoundException($"User with id {id} not found.");
            }

            return user;
        }

        public async Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId)
        {
            return await _ShowCaseContext.Users
                .Where(u => u.RoleId == roleId)
                .ToListAsync();
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _ShowCaseContext.Users
                .FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _ShowCaseContext.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetActiveUsersAsync()
        {
            return await _ShowCaseContext.Users
                .Where(u => u.Status == 1)  //"1" là trạng thái hoạt động
                .ToListAsync();
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await _ShowCaseContext.Users.Include(x=>x.Role).FirstOrDefaultAsync(u=>u.UserName==username && u.Password==password);
            return user;
        }
    }
}
