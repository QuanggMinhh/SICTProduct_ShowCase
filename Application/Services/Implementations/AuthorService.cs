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
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAuthorAsync(Author author)
        {
            author.CreatedAt = DateTime.Now;
            await _unitOfWork.Authors.AddAsync(author);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteAuthorAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetAuthorByIdAsync(id);
            if (author != null)
            {
                await _unitOfWork.Authors.Delete(author);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<Author>> GetAllAuthorAsync()
        {
            return await _unitOfWork.Authors.GetAllAsync();
        }

        public async Task<Author?> GetAuthorByIdAsync(int id)
        {
            return await _unitOfWork.Authors.GetAuthorByIdAsync(id);
        }

        

        public async Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name)
        {
            return await _unitOfWork.Authors.GetAuthorsByNameAsync(name);
        }

        public async Task<IEnumerable<Author>> GetAuthorsWithProductsAsync(int count)
        {
            return await _unitOfWork.Authors
                .GetAuthorsWithProductsAsync(count);
        }

        public async Task<IEnumerable<Author>> GetMostProlificAuthorsAsync(int count)
        {
            var authors = await _unitOfWork.Authors
                .GetMostProlificAuthorsAsync(count);

            return authors
                .OrderByDescending(a => a.ProductAuthors.Count)
                .Take(count)
                .ToList();
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            author.UpdatedAt = DateTime.Now;
            await _unitOfWork.Authors.Update(author);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
