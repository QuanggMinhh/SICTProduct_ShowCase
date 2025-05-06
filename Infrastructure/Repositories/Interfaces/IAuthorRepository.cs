using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        /// Lấy danh sách các tác giả theo tên.
        Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name);

        /// Lấy thông tin tác giả theo ID.
        Task<Author?> GetAuthorByIdAsync(int authorId);

        /// Lấy danh sách các tác giả có bài viết liên kết (sản phẩm).
        Task<IEnumerable<Author>> GetAuthorsWithProductsAsync(int count);

        /// Lấy các tác giả với nhiều bài viết nhất.
        Task<IEnumerable<Author>> GetMostProlificAuthorsAsync(int count);
    }
}
