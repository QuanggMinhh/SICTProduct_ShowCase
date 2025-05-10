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
        public string Image { get; set; }
        public int ManagerId { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }
        public int View { get; set; }
        public string Level { get; set; }
    }
}
