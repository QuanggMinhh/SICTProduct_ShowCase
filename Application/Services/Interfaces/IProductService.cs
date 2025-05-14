using Application.DTOs.ProductDTOs;
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
        Task<IEnumerable<ProductDetailDto>> GetAllProductAsync();
        Task<IEnumerable<ProductDetailDto>> GetAllFeatureProductAsync();
        Task<IEnumerable<ProductDetailDto>> GetAllProductInAdminAsync();
        Task<Product> GetProductByIdAsync(int id);
        //Task<PageResultDto<UserDto>> GetUserPageAsync(int page, int pageSize);
        Task<Product> AddProductAsync(ProductCreateDto product);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(Product product);

        Task<IEnumerable<ProductDetailDto?>> GetProductsByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Product>> GetProductsByStatusAsync(string status);
        Task<IEnumerable<Product>> GetMostViewedProductsAsync(int count);
        Task<ProductDetailDto?> GetProductDetailsAsync(int id);

        Task<IEnumerable<ProductDetailDto>> SearchProductAsync(int? categoryId, int? tagId, string? level);
    }
}
