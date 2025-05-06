using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IUploadFileRepository : IGenericRepository<UploadFile>
    {
        Task<List<UploadFile>> GetFilesByProductIdAsync(int productId);
        Task<List<UploadFile>> GetAllFileAsync();

    }
}
