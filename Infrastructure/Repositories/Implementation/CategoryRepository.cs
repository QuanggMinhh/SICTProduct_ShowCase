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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {

        }

        public async Task<IEnumerable<Category>> GetAllWithProductCountAsync()
        {
            return await _ShowCaseContext.Categories
                .Include(c => c.Products)
                .ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
        {
            return await _ShowCaseContext.Categories
                .Include(c => c.Products)
                .ToListAsync();
        }

        public async Task<Category?> GetCategoryByNameAsync(string categoryName)
        {
            return await _ShowCaseContext.Categories
                .FirstOrDefaultAsync(c => c.CategoryName == categoryName);
        }


    }
}
