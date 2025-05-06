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
    public class UploadFileRepository : GenericRepository<UploadFile>, IUploadFileRepository
    {
        public UploadFileRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }

        public async Task<List<UploadFile>> GetFilesByProductIdAsync(int productId)
        {
            return await _ShowCaseContext.UploadFiles
                .Where(uf => uf.ProductId == productId)
                .ToListAsync();
        }

        public async Task<List<UploadFile>> GetAllFileAsync()
        {
            return await _ShowCaseContext.UploadFiles.ToListAsync();
        }
    }
}
