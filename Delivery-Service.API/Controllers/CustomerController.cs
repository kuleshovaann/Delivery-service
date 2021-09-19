using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;

namespace Delivery_Service.API.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerServices.GetAllCustomers();
        }

        [HttpGet("{id}")]
        public Customer GetById(int id)
        {
            return _customerServices.GetCustomerById(id);
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            _customerServices.CreateCustomer(customer);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCustomer(Customer customer)
        {
            _customerServices.EditCustomer(customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerServices.DeleteCustomer(id);
            return Ok();
        }
    }
}
