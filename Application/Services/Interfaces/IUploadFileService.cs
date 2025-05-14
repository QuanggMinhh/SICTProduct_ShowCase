using Application.DTOs.UploadFileDTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IUploadFileService
    {
        Task<IEnumerable<UploadFile>> GetAllUploadFileAsync();
        //Task<PageResultDto<UserDto>> GetUserPageAsync(int page, int pageSize);
        //IQueryable<User> GetUsersAsync(int id);
        Task<UploadFile> GetUploadFileByIdAsync(int id);
        Task DeleteUploadFileAsync(int id);
        Task UpdateUploadFileAsync(UploadFile uploadFile);

        Task UploadFileAsync(IFormFile file, int id);
        Task<UploadFileUpdateDto> DownloadFileAsync(int id);
        Task<List<UploadFileUpdateDto>> GetAllFileAsync();

        Task<UploadFileUpdateDto?> GetFileByIdAsync(int id);

        Task<List<UploadFileUpdateDto>> GetFilesByProductIdAsync(int productId);
    }
}
