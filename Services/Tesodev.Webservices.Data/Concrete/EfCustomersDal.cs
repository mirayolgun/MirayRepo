using API.Infrastructure.Entities;
using API.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Tesodev.Webservices.Data.Abstract;
using Tesodev.Webservices.Data.Concrete.Contexts;

namespace Tesodev.Webservices.Data.Concrete
{
    public class EfCustomersDal : EfEntityRepositoryBase<Customer, TesodevdbContext>, ICustomersDal
    {
    }
}
