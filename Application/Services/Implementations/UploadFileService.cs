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
    }
}
