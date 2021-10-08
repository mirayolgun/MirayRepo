using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.Infrastructure.Entities
{
    public class Addess : BaseModel
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
