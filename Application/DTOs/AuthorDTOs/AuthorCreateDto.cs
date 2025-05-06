using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AuthorDTOs
{
    public class AuthorCreateDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AcademicTitle { get; set; }
        public string Degree { get; set; }
        public string Position { get; set; }
        public string AvatarUrl { get; set; }
        public bool IsStudent { get; set; }
    }
}
