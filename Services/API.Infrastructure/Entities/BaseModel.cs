using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.Entities
{
   public class BaseModel : IEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}
