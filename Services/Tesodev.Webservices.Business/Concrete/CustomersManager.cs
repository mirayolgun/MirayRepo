using API.Infrastructure.Entities;
using API.Infrastructure.Utilities.Result;
using API.Infrastructure.Utilities.Result.Success;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tesodev.Webservices.Business.Abstract;
using Tesodev.Webservices.Business.Constants.Messages;
using Tesodev.Webservices.Data.Abstract;

namespace Tesodev.Webservices.Business.Concrete
{
    public class CustomersManager : ICustomerService
    {
        private ICustomersDal _customersDal;
        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public IResult Create(Customer customer)
        {
            _customersDal.Add(customer);
            return new SuccessResult(CustomersMessage.CustomerAddedSuccessfully);
        }

        public IResult Update(Customer customer)
        {
            _customersDal.Update(customer);
            return new SuccessResult(CustomersMessage.CustomerUpdatedSuccessfully);
        }

        public IResult Delete(Customer customer)
        {
            _customersDal.Delete(customer);
            return new SuccessResult(CustomersMessage.CustomerDeletedSuccessfully);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customersDal.Get(p => p.Id == customerId));
        }

        public IDataResult<List<Customer>> Get()
        {
            return new SuccessDataResult<List<Customer>>(_customersDal.GetAll().ToList());
        }

        public IResult Validate(int customerId)
        {
            var existingCustomer = _customersDal.Get(p => p.Id == customerId);

            if (existingCustomer != null)
                return new SuccessResult(CustomersMessage.CustomerValidateSuccessfully);

            else 
                return new SuccessResult(CustomersMessage.CustomerValidateNotSuccessfully);
        }
    }
}
