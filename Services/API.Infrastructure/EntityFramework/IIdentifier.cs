using System;
using System.Collections.Generic;
using System.Text;

namespace API.Infrastructure.EntityFramework
{
    public interface IIdentifier
    {
        int Id { get; set; }
    }
}
