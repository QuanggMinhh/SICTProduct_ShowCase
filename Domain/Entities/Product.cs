using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public int ManagerId { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }
        public int View { get; set; }
        public string RejectReason { get; set; }
        public string Level { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        //[JsonIgnore]
        public Category Category { get; set; }
        public List<ProductTag> ProductTags { get; set; } = new();
        public List<UploadFile> UploadFiles { get; set; } = new();
    }
}
