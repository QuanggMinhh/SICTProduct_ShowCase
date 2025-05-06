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
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddRoleAsync(Role role)
        {
            role.CreatedAt = DateTime.Now;

            await _unitOfWork.Roles.AddAsync(role);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteRoleAsync(int id)
        {
            var role = await _unitOfWork.Roles.GetByIdAsync(id);
            if (role != null)
            {
                await _unitOfWork.Roles.Delete(role);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<Role>> GetAllRoleAsync()
        {
            return await _unitOfWork.Roles.GetAllAsync();
        }

        public async Task<Role> GetRoleByIdAsync(int id)
        {
            return await _unitOfWork.Roles.GetByIdAsync(id);
        }

        public async Task UpdateRoleAsync(Role role)
        {
            role.UpdatedAt = DateTime.Now;
            await _unitOfWork.Roles.Update(role);
            await _unitOfWork.SaveChangeAsync();
        }

        
    }
}
