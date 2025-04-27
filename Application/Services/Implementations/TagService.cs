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
    public class TagService : ITagService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TagService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddTagAsync(Tag tag)
        {
            tag.CreatedAt = DateTime.Now;

            await _unitOfWork.Tags.AddAsync(tag);
            await _unitOfWork.SaveChangeAsync();
        }

        //public async Task AddTagsAsync(List<Tag> tags)
        //{
        //    await _unitOfWork.Tags.AddAsync(tags);
        //}

        public async Task DeleteTagAsync(int id)
        {
            var tag = await _unitOfWork.Tags.GetByIdAsync(id);
            if (tag != null)
            {
                await _unitOfWork.Tags.Delete(tag);
                await _unitOfWork.SaveChangeAsync();
            }
        }

        public async Task<IEnumerable<Tag>> GetAllTagAsync()
        {
            return await _unitOfWork.Tags.GetAllAsync();
        }

        public async Task<Tag> GetTagByIdAsync(int id)
        {
            return await _unitOfWork.Tags.GetByIdAsync(id);
        }
        public async Task UpdateTagAsync(Tag tag)
        {
            tag.UpdatedAt = DateTime.Now;
            await _unitOfWork.Tags.Update(tag);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
