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
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }

        public async Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name)
        {
            return await _ShowCaseContext.Authors
                .Where(a => a.FullName.Contains(name))
                .ToListAsync();
        }

        public async Task<Author?> GetAuthorByIdAsync(int authorId)
        {
            return await _ShowCaseContext.Authors
                .Where(a => a.Id == authorId)
                .Include(a => a.ProductAuthors)  // Lấy thông tin sản phẩm liên quan (ProductAuthor)
                .ThenInclude(pa => pa.Product)  // Lấy thông tin sản phẩm
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Author>> GetAuthorsWithProductsAsync(int count)
        {
            return await _ShowCaseContext.Authors
                .Where(a => a.ProductAuthors.Any())  // Tác giả có ít nhất 1 sản phẩm
                .Take(count)
                .Include(a => a.ProductAuthors)
                    .ThenInclude(pa => pa.Product)  // Lấy sản phẩm liên kết với tác giả
                .ToListAsync();
        }

        public async Task<IEnumerable<Author>> GetMostProlificAuthorsAsync(int count)
        {
            return await _ShowCaseContext.Authors
                .Where(a => a.ProductAuthors.Any())  // Tác giả có ít nhất 1 sản phẩm
                .OrderByDescending(a => a.ProductAuthors.Count)  // Sắp xếp theo số lượng sản phẩm
                .Take(count)
                .Include(a => a.ProductAuthors)
                    .ThenInclude(pa => pa.Product)  // Lấy sản phẩm liên kết với tác giả
                .ToListAsync();
        }
    }
}
