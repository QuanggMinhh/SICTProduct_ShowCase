using Domain.Entities;
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
        Task<UploadFile> GetUploadFileByIdAsync(int id);
        //Task<PageResultDto<UserDto>> GetUserPageAsync(int page, int pageSize);
        //IQueryable<User> GetUsersAsync(int id);
        Task AddUploadFileAsync(UploadFile uploadFile);
        Task DeleteUploadFileAsync(int id);
        Task UpdateUploadFileAsync(UploadFile uploadFile);
    }
}
