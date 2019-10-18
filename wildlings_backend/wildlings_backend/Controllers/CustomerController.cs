using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wildlings_backend.Models;
using wildlings_backend.Models.Service;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetAllCustomer();
        }

        [HttpGet("{id}")]
        public Customer GetCustomer(long id)
        {
            return _customerService.GetCustomer(id);
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok();
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok();
        }
    }
}