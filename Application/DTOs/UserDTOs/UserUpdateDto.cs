using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UserDTOs
{
    public class UserUpdateDto : UserCreateDto
    {
        public int Id { get; set; }
        public int Status { get; set; }
    }
}
