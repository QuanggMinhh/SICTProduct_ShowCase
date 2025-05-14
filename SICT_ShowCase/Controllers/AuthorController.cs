using Application.DTOs.AuthorDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        // GET: api/author
        [HttpGet]
        public async Task<IActionResult> GetAllAuthor()
        {
            var authors = await _authorService.GetAllAuthorAsync();
            var result = _mapper.Map<IEnumerable<AuthorUpdateDto>>(authors);
            return Ok(result);
        }

        // GET: api/author/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);
            if (author == null) return NotFound();
            return Ok(_mapper.Map<AuthorUpdateDto>(author));
        }

        // POST: api/author
        [HttpPost("add-author")]
        public async Task<IActionResult> CreateAuthorAsync(AuthorCreateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var author = _mapper.Map<Author>(dto);
            await _authorService.AddAuthorAsync(author);
            return Ok(author);
        }

        // PUT: api/author/{id}
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(AuthorUpdateDto dto)
        {
            var existing = await _authorService.GetAuthorByIdAsync(dto.Id);
            if (existing == null) return NotFound();

            var author = _mapper.Map<Author>(dto);
            await _authorService.UpdateAuthorAsync(author);
            return Ok(author);
        }

        // DELETE: api/author/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);
            if (author == null) return NotFound();

            await _authorService.DeleteAuthorAsync(id);
            return NoContent();
        }

        // GET: api/author/by-name?name=abc
        [HttpGet("by-name")]
        public async Task<IActionResult> GetAuthorByName(string name)
        {
            var authors = await _authorService.GetAuthorsByNameAsync(name);
            var authorDto = _mapper.Map<IEnumerable<AuthorUpdateDto>>(authors);
            return Ok(authorDto);
        }

        // GET: api/author/with-products?count=5
        [HttpGet("with-products")]
        public async Task<IActionResult> GetAuthorsWithProducts([FromQuery] int count = 5)
        {
            var authors = await _authorService.GetAuthorsWithProductsAsync(count);
            var authorDto = _mapper.Map<IEnumerable<AuthorUpdateDto>>(authors);
            return Ok(authorDto);
        }

        // GET: api/author/most-prolific?count=5
        [HttpGet("most-prolific")]
        public async Task<IActionResult> GetMostProlificAuthors([FromQuery] int count = 5)
        {
            var authors = await _authorService.GetMostProlificAuthorsAsync(count);
            var authorDto = _mapper.Map<IEnumerable<AuthorUpdateDto>>(authors);
            return Ok(authorDto);
        }
    }
}
