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
    public class OrdersManager : IOrderService
    {
        private IOrdersDal _ordersDal;
        public OrdersManager(IOrdersDal ordersDal)
        {
            _ordersDal = ordersDal;
            //_productService = productService;
        }

        public IDataResult<List<Order>> Get()
        {
            return new SuccessDataResult<List<Order>>(_ordersDal.GetAll().ToList());
        }

        public IDataResult<Order> GetById(int OrderId)
        {
            return new SuccessDataResult<Order>(_ordersDal.Get(p => p.Id == OrderId));
        }

        public IDataResult<List<Order>> Get(int OrderId)
        {
            return new SuccessDataResult<List<Order>>(_ordersDal.GetAll().Where(o => o.Id == OrderId).ToList());
        }

        public IResult Create(Order order)
        {
            _ordersDal.Add(order);
            return new SuccessResult(OrdersMessage.OrderAddedSuccessfully);
        }

        public IResult Update(Order order)
        {
            _ordersDal.Update(order);
            return new SuccessResult(OrdersMessage.OrderUpdatedSuccessfully);
        }

        public IResult Delete(Order order)
        {
            //Expression<Func<Category, bool>> deleteFilterExpression = x => x.Id == category.Id;
            _ordersDal.Delete(order);
            return new SuccessResult(OrdersMessage.OrderDeletedSuccessfully);
        }

        public IResult ChangeStatus(int Id, string status)
        {
            var entity = _ordersDal.Get(p => p.Id == Id);

            entity.Status = status;

            _ordersDal.Update(entity);

            return new SuccessResult(OrdersMessage.OrderChangeStatusSuccessfully);

        }
    }
}
