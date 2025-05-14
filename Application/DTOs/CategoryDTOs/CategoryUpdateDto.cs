using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.CategoryDTOs
{
    public class CategoryUpdateDto : CategoryCreateDto
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ProductCount { get; set; }
    }
}
