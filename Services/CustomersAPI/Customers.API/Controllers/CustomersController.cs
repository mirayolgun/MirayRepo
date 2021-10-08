using API.Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesodev.Webservices.Business.Abstract;

namespace Customers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _customerService.Get();
            return StatusCode(result.Success ? 200 : 400, result);
        }

        //[HttpGet]
        //[Route("{id}")]
        [HttpGet("GetByCustomerId/{id}")]
        public IActionResult GetByCustomerId(int id)
        {
            var result = _customerService.GetById(id);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpPost("Create")]
        public IActionResult Create(Customer customers)
        {
            var result = _customerService.Create(customers);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        //[HttpPost("Delete")]
        [HttpDelete]
        public IActionResult Delete(Customer customers)
        {
            var result = _customerService.Delete(customers);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        //[HttpPost("Update")]
        [HttpPut]
        public IActionResult Update(Customer customers)
        {
            var result = _customerService.Update(customers);
            return StatusCode(result.Success ? 200 : 400, result);
        }

        [HttpGet("Validate/{id}")]
        public IActionResult Validate(int id)
        {
            var result = _customerService.Validate(id);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
