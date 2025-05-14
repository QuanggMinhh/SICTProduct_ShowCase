using Application.DTOs.ProductDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "Manager")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ITagService _tagService;
        private readonly IProductAuthorService _productAuthorService;
        private readonly IProductTagService _productTagService;
        private readonly IUploadFileService _uploadFileService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper, ITagService tagService, IProductAuthorService productAuthorService, IUploadFileService uploadFileService, IProductTagService productTagService)
        {
            _productService = productService;
            _mapper = mapper;
            _tagService = tagService;
            _productAuthorService = productAuthorService;
            _uploadFileService = uploadFileService;
            _productTagService = productTagService;
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> AddProduct([FromBody] ProductCreateDto productDto)
        {
            var product = await _productService.AddProductAsync(productDto);
            var pd = _mapper.Map<ProductDetailDto>(product);
            return Ok(pd);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productService.GetAllProductAsync();
            if(products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("admin-listproduct")]
        public async Task<IActionResult> GetAllProductInAdmin()
        {
            var products = await _productService.GetAllProductInAdminAsync();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("featured-product")]
        public async Task<IActionResult> GetAllFeaturedProduct()
        {
            var products = await _productService.GetAllFeatureProductAsync();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("search-product")]
        public async Task<IActionResult> SearchProductByCategoryTagLevel([FromQuery] int? categoryId, [FromQuery] int? tagId, [FromQuery] string? level)
        {
            var products = await _productService.SearchProductAsync(categoryId,tagId,level);
            if (!products.Any())
            {
                return Ok("Không tìm thấy sản phẩm phù hợp.");
            }
            return Ok(products);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductById(int Id)
        {
            var product = await _productService.GetProductDetailsAsync(Id);
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
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productDto)
        {
            //if(productUpdateDto.Status == "Đã duyệt" || productUpdateDto.Status == "Chờ duyệt")
            //{
            //    productUpdateDto.RejectReason = "";
            //}
            var product = await _productService.GetProductByIdAsync(productDto.Id);
            if (product == null)
            {
                return NotFound();
            }
            var updateProduct = _mapper.Map<Product>(productDto);
            await _productService.UpdateProductAsync(updateProduct);
            return Ok(updateProduct);
        }

        [HttpGet("by-category/{categoryId}")]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            var products =  await _productService.GetProductsByCategoryIdAsync(categoryId);
            if(products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("by-status/{status}")]
        public async Task<IActionResult> GetProductsByStatus(string status)
        {
            var products = await _productService.GetProductsByStatusAsync(status);
            var productDto = _mapper.Map<IEnumerable<ProductDetailDto>>(products);
            return Ok(productDto);
        }

        [HttpGet("most-viewed/{count}")]
        public async Task<IActionResult> GetMostViewedProduct(int count)
        {
            var products = await _productService.GetMostViewedProductsAsync(count);
            var productDto = _mapper.Map<IEnumerable<ProductUpdateDto>>(products);
            return Ok(productDto);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var product = await _productService.GetProductDetailsAsync(id);
            if (product == null) return NotFound();
            var productDto = _mapper.Map<ProductUpdateDto>(product);
            return Ok(productDto);
        }
    }
}
