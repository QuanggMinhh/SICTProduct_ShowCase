using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AcademicTitle { get; set; }   // GS, PGS, etc.
        public string Degree { get; set; }          // ThS, TS, CN, etc.
        public string Position { get; set; }        // Giảng viên, SV, etc. 
        public string AvatarUrl { get; set; }
        public bool IsStudent { get; set; }

        // Navigation property
        public List<ProductAuthor> ProductAuthors { get; set; } = new();
    }
}
