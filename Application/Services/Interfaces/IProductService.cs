using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(int id);
        //Task<PageResultDto<UserDto>> GetUserPageAsync(int page, int pageSize);
        Task AddProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(Product product);
    }
}
