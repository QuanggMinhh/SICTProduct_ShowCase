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
    public class UploadFileService : IUploadFileService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public UploadFileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddUploadFileAsync(UploadFile uploadFile)
        {
            uploadFile.CreatedAt = DateTime.Now;
            await _unitOfWork.UploadFiles.AddAsync(uploadFile);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteUploadFileAsync(int id)
        {
            var file = await _unitOfWork.UploadFiles.GetByIdAsync(id);
            if (file != null)
            {
                await _unitOfWork.UploadFiles.Delete(file);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<UploadFile>> GetAllUploadFileAsync()
        {
            return await _unitOfWork.UploadFiles.GetAllAsync();
        }

        public async Task<UploadFile> GetUploadFileByIdAsync(int id)
        {
            return await _unitOfWork.UploadFiles.GetByIdAsync(id);
        }

        public async Task UpdateUploadFileAsync(UploadFile uploadFile)
        {
            uploadFile.UpdatedAt = DateTime.Now;
            await _unitOfWork.UploadFiles.Update(uploadFile);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<UploadFileUpdateDto> DownloadFileAsync(int id)
        {
            var file = await _unitOfWork.UploadFiles.GetByIdAsync(id);
            if (file == null)
            {
                return null;
            }
            return new UploadFileUpdateDto
            {
                FileName = file.FileName,
                Data = file.Data,
                ContentType = file.ContentType,
                IsImage = file.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                Size = file.Size
            };
        }

        public async Task<List<UploadFileUpdateDto>> GetAllFileAsync()
        {
            var files = await _unitOfWork.UploadFiles.GetAllFileAsync();
            return files.Select(f => new UploadFileUpdateDto
            {
                Id = f.Id,
                FileName = f.FileName,
                Data = f.Data,
                ContentType = f.ContentType,
                ProductId = f.ProductId,
                IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                Size = f.Size
            }).ToList();

        }

        public async Task UploadFileAsync(IFormFile file, int id)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            //bool isImage = file.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase);
            var image = new UploadFile
            {
                FileName = file.FileName,
                Data = memoryStream.ToArray(),
                ContentType = file.ContentType,
                ProductId = id,
                IsImage = file.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                Size = file.Length > int.MaxValue? int.MaxValue: (int)file.Length

            };

            await _unitOfWork.UploadFiles.AddAsync(image);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<UploadFileUpdateDto?> GetFileByIdAsync(int id)
        {
            var file = await _unitOfWork.UploadFiles.GetByIdAsync(id);
            if (file == null) return null;
            return new UploadFileUpdateDto
            {
                Id = file.Id,
                FileName = file.FileName,
                Data = file.Data,
                ContentType = file.ContentType,
                ProductId = file.ProductId,
                IsImage = file.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                Size = file.Size
            };
        }

        public async Task<List<UploadFileUpdateDto>> GetFilesByProductIdAsync(int productId)
        {
            var files = await _unitOfWork.UploadFiles.GetFilesByProductIdAsync(productId);

            return files.Select(f => new UploadFileUpdateDto
            {   
                Id = f.Id,
                FileName = f.FileName,
                Data = f.Data,
                ContentType = f.ContentType,
                ProductId = f.ProductId,
                IsImage = f.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase),
                Size = f.Size
            }).ToList();
        }
    }
}
