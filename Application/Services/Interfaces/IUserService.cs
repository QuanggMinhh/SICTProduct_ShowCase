
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
    }
}
