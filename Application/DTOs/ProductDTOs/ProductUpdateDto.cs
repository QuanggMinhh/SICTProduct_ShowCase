using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ProductDTOs
{
    public class ProductUpdateDto : ProductCreateDto
    {
        public int Id { get; set; } 
        public string RejectReason { get; set; }
    }
}
