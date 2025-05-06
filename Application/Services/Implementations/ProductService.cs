using Application.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddProductAsync(Product product)
        {
            product.CreatedAt = DateTime.Now;
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if(product != null)
            {
                await _unitOfWork.Products.Delete(product);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task UpdateProductAsync(Product product)
        {
            product.UpdatedAt = DateTime.Now;
            await _unitOfWork.Products.Update(product);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            return await _unitOfWork.Products.GetProductsByCategoryAsync(categoryId);
        }


        public async Task<IEnumerable<Product>> GetNewestProductsAsync(int count)
        {
            return await _unitOfWork.Products.GetMostViewedProductsAsync(count);
        }

        public async Task<IEnumerable<Product>> GetMostViewedProductsAsync(int count)
        {
            return await _unitOfWork.Products.GetMostViewedProductsAsync(count);
        }

        public async Task<IEnumerable<Product>> GetProductsByStatusAsync(string status)
        {
            return await _unitOfWork.Products.GetProductsByStatusAsync(status);
        }

        public async Task<Product?> GetProductDetailsAsync(int id)
        {
            return await _unitOfWork.Products.GetProductDetailsAsync(id);
        }
    }
}
