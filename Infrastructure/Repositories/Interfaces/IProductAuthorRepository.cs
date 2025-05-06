using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IProductAuthorRepository : IGenericRepository<ProductAuthor>
    {
        /// Lấy danh sách các tác giả liên kết với sản phẩm.
        Task<IEnumerable<Author>> GetAuthorsByProductIdAsync(int productId);

        /// Lấy danh sách các sản phẩm liên kết với tác giả.
        Task<IEnumerable<Product>> GetProductsByAuthorIdAsync(int authorId);

        /// Thêm một mối quan hệ giữa tác giả và sản phẩm.
        Task AddProductAuthorAsync(ProductAuthor productAuthor);
    }
}
