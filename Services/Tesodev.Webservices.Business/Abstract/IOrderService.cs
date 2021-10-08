using API.Infrastructure.Entities;
using API.Infrastructure.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesodev.Webservices.Business.Abstract
{
    public interface IOrderService
    {
        IResult Create(Order order);
        IDataResult<Order> GetById(int orderId);
        IDataResult<List<Order>> Get();
        IDataResult<List<Order>> Get(int orderId);
        IResult Delete(Order order);
        IResult Update(Order order);
        IResult ChangeStatus(int Id, string status);
    }
}
