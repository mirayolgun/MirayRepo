using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.Entities
{
    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
