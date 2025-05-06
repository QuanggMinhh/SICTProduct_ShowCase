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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _ShowCaseContext.Products
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByStatusAsync(string status)
        {
            return await _ShowCaseContext.Products
                .Where(p => p.Status == status)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetMostViewedProductsAsync(int count)
        {
            return await _ShowCaseContext.Products
                .OrderByDescending(p => p.View)
                .Take(count)
                .ToListAsync();
        }

        public async Task<Product?> GetProductDetailsAsync(int productId)
        {
            return await _ShowCaseContext.Products
                .Where(p => p.Id == productId)
                .Include(p => p.Category)
                .Include(p => p.ProductTags)
                    .ThenInclude(pt => pt.Tag)
                .Include(p => p.UploadFiles)
                .FirstOrDefaultAsync();
        }
    }
}
