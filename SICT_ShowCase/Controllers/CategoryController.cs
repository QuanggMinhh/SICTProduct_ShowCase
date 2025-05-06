using Application.DTOs.CategoryDTOs;
using Application.DTOs.UserDTOs;
using Application.Services.Implementations;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCategoryByIdAsync(int id)
        {

            var category = await _categoryService.GetCategoryByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryCreateDto>(category);
            return Ok(categoryDto);
        }

        [HttpPost("them-moi")]
        public async Task<ActionResult> CreateCategory(CategoryCreateDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            await _categoryService.AddCategoryAsync(category);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCategoryAsync()
        {
            var category = await _categoryService.GetAllCategoryAsync();
            var categoryDto = _mapper.Map<IEnumerable<CategoryCreateDto>>(category);
            return Ok(categoryDto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return BadRequest();
            }
            await _categoryService.DeleteCategoryAsync(category.Id);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCategory(CategoryUpdateDto categoryDto)
        {

            var category = await _categoryService.GetCategoryByIdAsync(categoryDto.Id);
            if (category == null)
            {
                return BadRequest();
            }
            var updateCategory = _mapper.Map<Category>(categoryDto);
            await _categoryService.UpdateCategoryAsync(updateCategory);
            return Ok();
        }

        [HttpGet("with-products")]
        public async Task<IActionResult> GetCategoriesWithProducts()
        {
            var result = await _categoryService.GetCategoriesWithProductsAsync();
            return Ok(result);
        }

        // GET: api/category/by-name/{name}
        [HttpGet("by-name/{name}")]
        public async Task<IActionResult> GetCategoryByName(string name)
        {
            var category = await _categoryService.GetCategoryByNameAsync(name);
            if (category == null)
                return NotFound();

            return Ok(category);
        }
    }
}
