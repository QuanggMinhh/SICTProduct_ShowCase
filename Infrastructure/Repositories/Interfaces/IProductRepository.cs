using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        /// Lấy danh sách sản phẩm theo danh mục.
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);


        /// Lấy danh sách sản phẩm theo trạng thái.
        Task<IEnumerable<Product>> GetProductsByStatusAsync(string status);

        /// Lấy danh sách sản phẩm phổ biến nhất (theo lượt xem).
        Task<IEnumerable<Product>> GetMostViewedProductsAsync(int count);

        /// Lấy sản phẩm theo ID và bao gồm các thông tin chi tiết (category, tags, files...).
        Task<Product?> GetProductDetailsAsync(int productId);
    }
}
