
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task DeleteUserAsync(int id);
        Task UpdateUserAsync(User user);
        Task<User> FindByIdAsync(int id);

        /// Lấy danh sách người dùng theo vai trò.
        Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId);

        /// Tìm người dùng theo tên người dùng (UserName).
        Task<User> GetUserByUserNameAsync(string userName);

        /// Tìm người dùng theo email.
        Task<User> GetUserByEmailAsync(string email);

        /// Lấy danh sách người dùng có trạng thái hoạt động.
        Task<IEnumerable<User>> GetActiveUsersAsync();

        Task<User> Authenticate(string username, string password);
    }
}
