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
    public class ProductAuthorRepository : GenericRepository<ProductAuthor>, IProductAuthorRepository
    {
        public ProductAuthorRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }

        public async Task<IEnumerable<Author>> GetAuthorsByProductIdAsync(int productId)
        {
            return await _ShowCaseContext.ProductAuthors
                .Where(pa => pa.ProductId == productId)
                .Include(pa => pa.Author)  // Lấy tác giả liên kết với sản phẩm
                .Select(pa => pa.Author)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByAuthorIdAsync(int authorId)
        {
            return await _ShowCaseContext.ProductAuthors
                .Where(pa => pa.AuthorId == authorId)
                .Include(pa => pa.Product)  // Lấy sản phẩm liên kết với tác giả
                .Select(pa => pa.Product)
                .ToListAsync();
        }

        public async Task AddProductAuthorAsync(ProductAuthor productAuthor)
        {
            await _ShowCaseContext.ProductAuthors.AddAsync(productAuthor);
            await _ShowCaseContext.SaveChangesAsync();
        }
    }
}
