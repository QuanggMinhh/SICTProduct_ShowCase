using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        /// Lấy danh sách các tag mới nhất.
        Task<IEnumerable<Tag>> GetLatestTagsAsync(int count);

        /// Lấy danh sách các tag có trong nhiều bài viết nhất.
        Task<IEnumerable<Tag>> GetMostUsedTagsAsync(int count);

        /// Lấy danh sách các tag theo tên.
        Task<IEnumerable<Tag>> GetTagsByNameAsync(string name);

        
    }
}
