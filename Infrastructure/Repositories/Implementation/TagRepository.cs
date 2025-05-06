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
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(SICT_ShowCaseContext showCaseContext) : base(showCaseContext)
        {
        }
        public async Task<IEnumerable<Tag>> GetLatestTagsAsync(int count)
        {
            return await _ShowCaseContext.Tags
                .OrderByDescending(t => t.CreatedAt)
                .Take(count)
                .ToListAsync();
        }

        public async Task<IEnumerable<Tag>> GetMostUsedTagsAsync(int count)
        {
            return await _ShowCaseContext.Tags
                .Include(t => t.ProductTags)
                .OrderByDescending(t => t.ProductTags.Count)
                .Take(count)
                .ToListAsync();
        }

        public async Task<IEnumerable<Tag>> GetTagsByNameAsync(string name)
        {
            return await _ShowCaseContext.Tags
                .Where(t => t.Name.Contains(name))  // Tìm kiếm tên tag chứa chuỗi nhập vào
                .ToListAsync();
        }
    }
}
