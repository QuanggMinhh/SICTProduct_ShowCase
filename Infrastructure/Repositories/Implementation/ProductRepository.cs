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
                .Where(p => p.Status == "Đã duyệt")
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .Include(p=>p.ProductAuthors).ThenInclude(pa=>pa.Author)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByStatusAsync(string status)
        {
            return await _ShowCaseContext.Products
                .Where(p => p.Status == "Đã duyệt")
                .Where(p => p.Status == status)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetMostViewedProductsAsync(int count)
        {
            return await _ShowCaseContext.Products
                .Where(p => p.Status == "Đã duyệt")
                .OrderByDescending(p => p.View)
                .Take(count)
                .ToListAsync();
        }

        public async Task<Product?> GetProductDetailsAsync(int productId)
        {
            return await _ShowCaseContext.Products
                .Where(p => p.Id == productId)
                .Include(p => p.Category)
                .Include (p => p.ProductAuthors)
                    .ThenInclude(pa =>pa.Author)
                .Include(p => p.ProductTags)
                    .ThenInclude(pt => pt.Tag)
                .Include(p => p.UploadFiles)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductDetail()
        {
            return await _ShowCaseContext.Products
            .Where(p => p.Status == "Đã duyệt")
            .Include(p=>p.Category)
            .Include(p => p.ProductAuthors).ThenInclude(pa => pa.Author)
            .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
            .Include(p => p.UploadFiles)
            .ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetAllFeatureProductDetail()
        {
            return await _ShowCaseContext.Products
                .Where(p => p.Status == "Đã duyệt" && p.Level == "Quốc gia")
                .Include(p => p.Category)
                .Include(p => p.ProductAuthors).ThenInclude(pa => pa.Author)
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .Include(p => p.UploadFiles)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductInAdmin()
        {
            return await _ShowCaseContext.Products
            .Include(p => p.Category)
            .Include(p => p.ProductAuthors).ThenInclude(pa => pa.Author)
            .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
            .Include(p => p.UploadFiles)
            .ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchProductByCategoryTagLevel(int? categoryId, int? tagId, string? level)
        {
            var query = _ShowCaseContext.Products
                .Include(p => p.Category)
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .Include(p => p.ProductAuthors).ThenInclude(pa => pa.Author)
                .Include(p => p.UploadFiles)
                .Where(p => p.Status == "Đã duyệt") // Chỉ lấy sản phẩm đã duyệt
                .AsQueryable();

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

            if (tagId.HasValue)
            {
                query = query.Where(p => p.ProductTags.Any(pt => pt.TagId == tagId.Value));
            }

            if (!string.IsNullOrWhiteSpace(level))
            {
                query = query.Where(p => p.Level == level);
            }

            return await query.ToListAsync();
        }
    }
    
}
