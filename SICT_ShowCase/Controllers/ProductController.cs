using Application.DTOs.ProductDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> AddProduct(ProductCreateDto productCreateDto)
        {
            var product = _mapper.Map<Product>(productCreateDto);
            await _productService.AddProductAsync(product);
            return Ok(product);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productService.GetAllProductAsync();
            var productDto = _mapper.Map<IEnumerable<Product>>(products);
            return Ok(productDto);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductById(int Id)
        {
            var product = await _productService.GetProductByIdAsync(Id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            var product = await _productService.GetProductByIdAsync(Id);
            if (product == null)
            {
                return NotFound();
            }
            await _productService.DeleteProductAsync(Id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var product = await _productService.GetProductByIdAsync(productUpdateDto.Id);
            if (product == null)
            {
                return NotFound();
            }
            var updateProduct = _mapper.Map<Product>(productUpdateDto);
            await _productService.UpdateProductAsync(updateProduct);
            return Ok(updateProduct);
        }
    }
}
