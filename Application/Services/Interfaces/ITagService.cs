using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllTagAsync();
        Task<Tag> GetTagByIdAsync(int id);
        Task AddTagAsync(Tag tag);
        Task DeleteTagAsync(int id);
        Task UpdateTagAsync(Tag tag);
    }
}
