using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UploadFile : BaseEntity
    {
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public string ContentType { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
