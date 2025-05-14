using Application.DTOs.AuthorDTOs;
using Application.DTOs.CategoryDTOs;
using Application.DTOs.ProductDTOs;
using Application.DTOs.TagDTOs;
using Application.DTOs.UploadFileDTOs;
using Application.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories.UnitOfWork;
using Microsoft.AspNetCore.Http;
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
        public async Task<Product> AddProductAsync(ProductCreateDto dto)
        {

            // Tạo Product với quan hệ
            var product = new Product
            {
                Title = dto.Title,
                Description = dto.Description,
                Content = dto.Content,
                Image = dto.Image,
                ManagerId = dto.ManagerId,
                CategoryId = dto.CategoryId,
                Status = dto.Status,
                Level = dto.Level,
                View = 0,
                CreatedAt = DateTime.UtcNow
            };

                // 2. Gán quan hệ n-n với Author
            if (dto.Authors != null && dto.Authors.Any())
            {
                product.ProductAuthors = dto.Authors
                    .Where(aid => aid.HasValue)
                    .Select(aid => new ProductAuthor
                    {
                        AuthorId = aid!.Value
                    })
                    .ToList();
            }

            // 3. Gán quan hệ n-n với Tag
            if (dto.Tags != null && dto.Tags.Any())
            {
                product.ProductTags = dto.Tags
                    .Where(tid => tid.HasValue)
                    .Select(tid => new ProductTag
                    {
                        TagId = tid!.Value
                    })
                    .ToList();
            }

            await _unitOfWork.Products.AddAsync(product);

            //using var memoryStream = new MemoryStream();
            //await file.CopyToAsync(memoryStream);
            //var uploadFiles = dto.UploadFiles.Select(f => new UploadFile
            //{
                
            //    FileName = f.FileName,
            //    ContentType = f.ContentType,
            //    Data = f.Data,
            //    ProductId = product.Id
            //}).ToList();
            //await _unitOfWork.UploadFiles.AddAsync(uploadFiles);
            await _unitOfWork.SaveChangeAsync();
            return product;
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

        public async Task<IEnumerable<ProductDetailDto>> GetAllProductAsync()
        {
            var products = await _unitOfWork.Products.GetAllProductDetail();

            return products.Select(p => new ProductDetailDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Content = p.Content,
                Image = p.Image,
                ManagerId = p.ManagerId,
                CategoryId = p.CategoryId,
                View = p.View,
                Status = p.Status,
                Level = p.Level,
                CreatedAt = p.CreatedAt,
                Category = p.Category != null ? new CategoryUpdateDto
                {
                    Id = p.Id,
                    CategoryName = p.Category.CategoryName,
                    Description = p.Category.Description,
                    CreatedAt = p.Category.CreatedAt
                } : null,
                Authors = p.ProductAuthors.Select(pa => new AuthorUpdateDto
                {
                    Id = pa.Author.Id,
                    FullName = pa.Author.FullName,
                    Email = pa.Author.Email,
                    PhoneNumber = pa.Author.PhoneNumber,
                    AcademicTitle = pa.Author.AcademicTitle,
                    Degree = pa.Author.Degree,
                    Position = pa.Author.Position,
                    AvatarUrl = pa.Author.AvatarUrl,
                    IsStudent = pa.Author.IsStudent
                }).ToList(),
                Tags = p.ProductTags.Select(pt => new TagUpdateDto
                {
                    Id = pt.Tag.Id,
                    Name = pt.Tag.Name
                }).ToList(),
                UploadFiles = p.UploadFiles.Select(f => new UploadFileUpdateDto
                {
                    Id = f.Id,
                    FileName = f.FileName,
                    ContentType = f.ContentType,
                    Data = f.Data,
                    IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                    Size = f.Size
                }).ToList()
            }).ToList();
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

        public async Task<IEnumerable<ProductDetailDto>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await _unitOfWork.Products.GetProductsByCategoryAsync(categoryId);

            var result = products.Select(p => new ProductDetailDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Content = p.Content,
                Image = p.Image,
                ManagerId = p.ManagerId,
                CategoryId = p.CategoryId,
                View = p.View,
                Status = p.Status,
                Level = p.Level,
                CreatedAt = p.CreatedAt,
                Category = p.Category != null ? new CategoryUpdateDto
                {
                    Id = p.Category.Id,
                    CategoryName = p.Category.CategoryName,
                    Description = p.Category.Description,
                    CreatedAt = p.Category.CreatedAt,
                } : null,
                Authors = p.ProductAuthors
                    .Select(pa => new AuthorUpdateDto
                    {
                        Id = pa.Author.Id,
                        FullName = pa.Author.FullName,
                        Email = pa.Author.Email,
                        PhoneNumber = pa.Author.PhoneNumber,
                        AcademicTitle = pa.Author.AcademicTitle,
                        Degree = pa.Author.Degree,
                        Position = pa.Author.Position,
                        AvatarUrl = pa.Author.AvatarUrl,
                        IsStudent = pa.Author.IsStudent,
                    }).ToList(),
                Tags = p.ProductTags
                    .Select(pt => new TagUpdateDto
                    {
                        Id = pt.Tag.Id,
                        Name = pt.Tag.Name
                    }).ToList(),
                UploadFiles = p.UploadFiles
                    .Select(f => new UploadFileUpdateDto
                    {
                        Id = f.Id,
                        Data = f.Data,
                        ContentType = f.ContentType,
                        FileName = f.FileName,
                        IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                        Size = f.Size
                    }).ToList()
            }).ToList();
            return result;  

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

        public async Task<ProductDetailDto?> GetProductDetailsAsync(int id)
        {
            var product = await _unitOfWork.Products.GetProductDetailsAsync(id);

            if (product == null) return null;

            var dto = new ProductDetailDto
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Content = product.Content,
                Image = product.Image,
                ManagerId = product.ManagerId,
                CategoryId = product.CategoryId,
                View = product.View+=1,
                Status = product.Status,
                Level = product.Level,
                Category = product.Category != null ? new CategoryUpdateDto
                {
                    Id = product.Category.Id,
                    CategoryName = product.Category.CategoryName,
                    Description = product.Category.Description,
                    CreatedAt = product.Category.CreatedAt,
                } : null,
                Authors = product.ProductAuthors
                    .Select(pa => new AuthorUpdateDto
                    {
                        Id = pa.Author.Id,
                        FullName = pa.Author.FullName,
                        Email = pa.Author.Email,
                        PhoneNumber = pa.Author.PhoneNumber,
                        AcademicTitle = pa.Author.AcademicTitle,
                        Degree = pa.Author.Degree,
                        Position = pa.Author.Position,
                        AvatarUrl = pa.Author.AvatarUrl,
                        IsStudent = pa.Author.IsStudent,
                    }).ToList(),
                Tags = product.ProductTags
                    .Select(pt => new TagUpdateDto
                    {
                        Id = pt.Tag.Id,
                        Name = pt.Tag.Name
                    }).ToList(),
                UploadFiles = product.UploadFiles
                    .Select(f => new UploadFileUpdateDto
                    {
                        Id = f.Id,
                        Data = f.Data,
                        ContentType = f.ContentType,
                        FileName = f.FileName,
                        IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                        Size = f.Size
                    }).ToList()
            };

            return dto;

        }

        public async Task<IEnumerable<ProductDetailDto>> GetAllFeatureProductAsync()
        {
            var products = await _unitOfWork.Products.GetAllFeatureProductDetail();

            return products.Select(p => new ProductDetailDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Content = p.Content,
                Image = p.Image,
                ManagerId = p.ManagerId,
                CategoryId = p.CategoryId,
                View = p.View,
                Status = p.Status,
                Level = p.Level,
                CreatedAt = p.CreatedAt,
                Category = p.Category != null ? new CategoryUpdateDto
                {
                    Id = p.Category.Id,
                    CategoryName = p.Category.CategoryName,
                    Description = p.Category.Description,
                    CreatedAt = p.Category.CreatedAt
                } : null,
                Authors = p.ProductAuthors.Select(pa => new AuthorUpdateDto
                {
                    Id = pa.Author.Id,
                    FullName = pa.Author.FullName,
                    Email = pa.Author.Email,
                    PhoneNumber = pa.Author.PhoneNumber,
                    AcademicTitle = pa.Author.AcademicTitle,
                    Degree = pa.Author.Degree,
                    Position = pa.Author.Position,
                    AvatarUrl = pa.Author.AvatarUrl,
                    IsStudent = pa.Author.IsStudent
                }).ToList(),
                Tags = p.ProductTags.Select(pt => new TagUpdateDto
                {
                    Id = pt.Tag.Id,
                    Name = pt.Tag.Name
                }).ToList(),
                UploadFiles = p.UploadFiles.Select(f => new UploadFileUpdateDto
                {
                    Id = f.Id,
                    FileName = f.FileName,
                    ContentType = f.ContentType,
                    Data = f.Data,
                    IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                    Size = f.Size
                }).ToList()
            }).ToList();
        }

        public async Task<IEnumerable<ProductDetailDto>> GetAllProductInAdminAsync()
        {
            var products = await _unitOfWork.Products.GetAllProductInAdmin();

            return products.Select(p => new ProductDetailDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Content = p.Content,
                Image = p.Image,
                ManagerId = p.ManagerId,
                CategoryId = p.CategoryId,
                View = p.View,
                Status = p.Status,
                Level = p.Level,
                CreatedAt = p.CreatedAt,
                Category = p.Category != null ? new CategoryUpdateDto
                {
                    Id = p.Category.Id,
                    CategoryName = p.Category.CategoryName,
                    Description = p.Category.Description,
                    CreatedAt = p.Category.CreatedAt
                } : null,
                Authors = p.ProductAuthors.Select(pa => new AuthorUpdateDto
                {
                    Id = pa.Author.Id,
                    FullName = pa.Author.FullName,
                    Email = pa.Author.Email,
                    PhoneNumber = pa.Author.PhoneNumber,
                    AcademicTitle = pa.Author.AcademicTitle,
                    Degree = pa.Author.Degree,
                    Position = pa.Author.Position,
                    AvatarUrl = pa.Author.AvatarUrl,
                    IsStudent = pa.Author.IsStudent
                }).ToList(),
                Tags = p.ProductTags.Select(pt => new TagUpdateDto
                {
                    Id = pt.Tag.Id,
                    Name = pt.Tag.Name
                }).ToList(),
                UploadFiles = p.UploadFiles.Select(f => new UploadFileUpdateDto
                {
                    Id = f.Id,
                    FileName = f.FileName,
                    ContentType = f.ContentType,
                    Data = f.Data,
                    IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                    Size = f.Size
                }).ToList()
            }).ToList();
        }

        public async Task<IEnumerable<ProductDetailDto>> SearchProductAsync(int? categoryId, int? tagId, string? level)
        {
            var products = await _unitOfWork.Products.SearchProductByCategoryTagLevel(categoryId, tagId, level);

            return products.Select(p => new ProductDetailDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Content = p.Content,
                Image = p.Image,
                ManagerId = p.ManagerId,
                CategoryId = p.CategoryId,
                View = p.View,
                Status = p.Status,
                Level = p.Level,
                CreatedAt = p.CreatedAt,
                Category = p.Category != null ? new CategoryUpdateDto
                {
                    Id = p.Id,
                    CategoryName = p.Category.CategoryName,
                    Description = p.Category.Description,
                    CreatedAt = p.Category.CreatedAt
                } : null,
                Authors = p.ProductAuthors.Select(pa => new AuthorUpdateDto
                {
                    Id = pa.Author.Id,
                    FullName = pa.Author.FullName,
                    Email = pa.Author.Email,
                    PhoneNumber = pa.Author.PhoneNumber,
                    AcademicTitle = pa.Author.AcademicTitle,
                    Degree = pa.Author.Degree,
                    Position = pa.Author.Position,
                    AvatarUrl = pa.Author.AvatarUrl,
                    IsStudent = pa.Author.IsStudent
                }).ToList(),
                Tags = p.ProductTags.Select(pt => new TagUpdateDto
                {
                    Id = pt.Tag.Id,
                    Name = pt.Tag.Name
                }).ToList(),
                UploadFiles = p.UploadFiles.Select(f => new UploadFileUpdateDto
                {
                    Id = f.Id,
                    FileName = f.FileName,
                    ContentType = f.ContentType,
                    Data = f.Data,
                    IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                    Size = f.Size
                }).ToList()
            }).ToList();
        }
    }
}
