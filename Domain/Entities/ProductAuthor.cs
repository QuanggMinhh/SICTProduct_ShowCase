using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductAuthor
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
