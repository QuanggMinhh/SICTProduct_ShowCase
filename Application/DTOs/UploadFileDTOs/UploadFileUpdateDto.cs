using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UploadFileDTOs
{
    public class UploadFileUpdateDto : UploadFileCreateDto
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
