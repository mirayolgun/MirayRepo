using API.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.Entities
{
        
    public class Order : BaseModel, IIdentifier
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public List<Addess> Addesses { get; set; }
    }
}
