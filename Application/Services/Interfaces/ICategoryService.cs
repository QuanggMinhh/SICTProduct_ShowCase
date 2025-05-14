using Application.DTOs.CategoryDTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryUpdateDto>> GetAllCategoryAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        //Task<PageResultDto<UserDto>> GetUserPageAsync(int page, int pageSize);
        Task AddCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(Category category);

        Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
        Task<Category?> GetCategoryByNameAsync(string categoryName);
    }
}
