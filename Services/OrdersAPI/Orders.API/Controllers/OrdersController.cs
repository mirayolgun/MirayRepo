using API.Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesodev.Webservices.Business.Abstract;

namespace Orders.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _orderService.Get();
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpGet("GetByOrderId/{id}")]
        //[Route("{id}")]
        public IActionResult GetByOrderId(int id)
        {
            var result = _orderService.GetById(id);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpGet("GetListByOrderId/{id}")]
        //[Route("{id}")]
        public IActionResult GetListByOrderId(int id)
        {
            var result = _orderService.Get(id);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpPost("Create")]
        public IActionResult Create(Order order)
        {
            var result = _orderService.Create(order);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        //[HttpPost("Delete")]
        [HttpDelete]
        public IActionResult Delete(Order order)
        {
            var result = _orderService.Delete(order);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        //[HttpPost("Update")]
        [HttpPut]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpPost("ChangeStatus")]
        public IActionResult ChangeStatus(int Id, string status)
        {
            var result = _orderService.ChangeStatus(Id, status);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
