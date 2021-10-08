using API.Infrastructure;
using API.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesodev.Webservices.Data.Abstract
{
    public interface IOrdersDal : IEntityRepository<Order>
    {

    }
}
