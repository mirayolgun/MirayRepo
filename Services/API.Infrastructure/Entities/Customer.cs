using API.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.Entities
{
   public class Customer : BaseModel, IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
        public List<Addess> Addesses { get; set; }
    }
}
