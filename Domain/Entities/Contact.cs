using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
