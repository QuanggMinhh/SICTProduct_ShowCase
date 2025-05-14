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
    public class ProductCreateDto
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int ManagerId { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }
        public int View { get; set; }
        public string Level { get; set; }
        //public CategoryUpdateDto? Category { get; set; }
        public List<int?> Authors { get; set; } = new();
        public List<int?> Tags { get; set; } = new();
        public DateTime CreatedAt { get; set; }
    }
}
