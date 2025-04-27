using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tag :BaseEntity
    {
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; set; } = new();
    }
}
