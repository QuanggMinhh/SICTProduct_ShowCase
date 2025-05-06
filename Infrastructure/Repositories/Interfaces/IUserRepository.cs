using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task AddUserAsync(User user);
        Task<User> FindByIdAsync(int id);

        /// Lấy danh sách người dùng theo vai trò.
        Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId);

        /// Tìm người dùng theo tên người dùng (UserName).
        Task<User> GetUserByUserNameAsync(string userName);

        /// Tìm người dùng theo email.
        Task<User> GetUserByEmailAsync(string email);

        /// Lấy danh sách người dùng có trạng thái hoạt động.
        Task<IEnumerable<User>> GetActiveUsersAsync();
    }
}
