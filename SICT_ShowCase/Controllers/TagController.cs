using Application.DTOs.TagDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;
        private readonly IMapper _mapper;

        public TagController(ITagService tagService, IMapper mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }

        // GET: api/tag
        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            var tags = await _tagService.GetAllTagAsync();
            var tagDto = _mapper.Map<IEnumerable<Tag>>(tags);
            return Ok(tagDto);
        }

        // GET: api/tag/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagById(int id)
        {
            var tag = await _tagService.GetTagByIdAsync(id);
            if (tag == null)
                return NotFound();
            return Ok(tag);
        }

        [HttpGet("byName/{name}")]
        public async Task<IActionResult> GetTagByName(string name)
        {
            var tag = await _tagService.GetTagByNameAsync(name);
            if (tag == null)
                return NotFound();
            return Ok(tag);
        }

        // GET: api/tag/newest
        [HttpGet("newest")]
        public async Task<IActionResult> GetNewestTags()
        {
            var tags = await _tagService.GetNewestTagsAsync(5);
            var tagDto = _mapper.Map<IEnumerable<Tag>>(tags);
            return Ok(tagDto);
        }

        // GET: api/tag/most-used
        [HttpGet("most-used")]
        public async Task<IActionResult> GetMostUsedTags()
        {
            var tags = await _tagService.GetMostUsedTagsAsync(5);
            var tagDto = _mapper.Map<IEnumerable<Tag>>(tags);
            return Ok(tagDto);
        }

        // POST: api/tag
        [HttpPost]
        public async Task<IActionResult> CreateTag(TagCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var tag = _mapper.Map<Tag>(dto);
            await _tagService.AddTagAsync(tag);
            return Ok();
        }

        // PUT: api/tag/{id}
        [HttpPut]
        public async Task<IActionResult> UpdateTag(TagUpdateDto dto)
        {
            var existing = await _tagService.GetTagByIdAsync(dto.Id);
            if (existing == null)
                return NotFound();

            var tag = _mapper.Map<Tag>(dto);
            await _tagService.UpdateTagAsync(tag);

            return Ok();
        }

        // DELETE: api/tag/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            var tag = await _tagService.GetTagByIdAsync(id);
            if (tag == null)
                return NotFound();

            await _tagService.DeleteTagAsync(id);
            return Ok();
        }
    }
}
