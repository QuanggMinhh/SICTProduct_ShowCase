using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAuthorAsync();
        Task<Author> GetAuthorByIdAsync(int id);
        Task AddAuthorAsync(Author author);
        Task DeleteAuthorAsync(int id);
        Task UpdateAuthorAsync(Author author);

        /// Lấy danh sách các tác giả theo tên.
        Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name);

        /// Lấy danh sách các tác giả có bài viết liên kết (sản phẩm).
        Task<IEnumerable<Author>> GetAuthorsWithProductsAsync(int count);

        /// Lấy các tác giả với nhiều bài viết nhất.
        Task<IEnumerable<Author>> GetMostProlificAuthorsAsync(int count);
    }
}
