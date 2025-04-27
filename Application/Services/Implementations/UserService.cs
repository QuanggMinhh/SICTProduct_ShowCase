using Application.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddUserAsync(User user)
        {
            user.CreatedAt = DateTime.Now;
            user.RoleId = _unitOfWork.Roles.GetByIdAsync(2).Result.Id;
            await _unitOfWork.Users.AddUserAsync(user);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            if (user != null)
            {
                await _unitOfWork.Users.Delete(user);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _unitOfWork.Users.FindByIdAsync(id);
        }
        public async Task UpdateUserAsync(User user)
        {
            user.UpdatedAt = DateTime.Now;
            await _unitOfWork.Users.Update(user);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
