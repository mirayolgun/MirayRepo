using API.Infrastructure.Entities;
using API.Infrastructure.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesodev.Webservices.Business.Abstract
{
    public interface ICustomerService
    {
        IResult Create(Customer customer);
        IDataResult<Customer> GetById(int customerId);
        IDataResult<List<Customer>> Get();
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IResult Validate(int customerId);
    }
}
