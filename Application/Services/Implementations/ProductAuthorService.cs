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
    public class ProductAuthorService : IProductAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductAuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddProductAuthorAsync(ProductAuthor productAuthor)
        {
            await _unitOfWork.ProductAuthors.AddProductAuthorAsync(productAuthor);  
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Author>> GetAuthorsByProductIdAsync(int productId)
        {
            return await _unitOfWork.ProductAuthors.GetAuthorsByProductIdAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetProductsByAuthorIdAsync(int authorId)
        {
            return await _unitOfWork.ProductAuthors.GetProductsByAuthorIdAsync(authorId);
        }
    }
}
