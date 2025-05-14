using Application.DTOs.AuthorDTOs;
using Application.DTOs.CategoryDTOs;
using Application.DTOs.TagDTOs;
using Application.DTOs.UploadFileDTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ProductDTOs
{
    public class ProductDetailDto : ProductCreateDto
    {
        public int Id { get; set; }
        public string RejectReason { get; set; }
        public string Content { get; set; }
        public CategoryUpdateDto? Category { get; set; }
        public List<AuthorUpdateDto> Authors { get; set; } = new();
        public List<TagUpdateDto> Tags { get; set; } = new();
        public List<UploadFileUpdateDto> UploadFiles { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
