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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task AddCategoryAsync(Category category)
        {
            category.CreatedAt = DateTime.Now;
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);
            if (category != null)
            {
                await _unitOfWork.Categories.Delete(category);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }


        public async Task UpdateCategoryAsync(Category category)
        {
            category.UpdatedAt = DateTime.Now;
            await _unitOfWork.Categories.Update(category);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<Category?> GetCategoryByNameAsync(string categoryName)
        {
            return await _unitOfWork.Categories.GetCategoryByNameAsync(categoryName);
        }

        public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
        {
            return await _unitOfWork.Categories.GetCategoriesWithProductsAsync();
        }
    }
}
