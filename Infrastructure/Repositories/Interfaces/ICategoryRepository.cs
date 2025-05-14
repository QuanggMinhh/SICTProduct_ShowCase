using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();

        Task<Category?> GetCategoryByNameAsync(string categoryName);

        Task<IEnumerable<Category>> GetAllWithProductCountAsync();
    }
}
