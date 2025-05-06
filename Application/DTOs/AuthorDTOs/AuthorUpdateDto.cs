using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AuthorDTOs
{
    public class AuthorUpdateDto : AuthorCreateDto
    {
        public int Id { get; set; }
    }
}
