using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;

namespace Delivery_Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderServices.GetAllOrders();
        }

        [HttpGet("{id}")]
        public Order GetById(int id)
        {
            return _orderServices.GetOrderById(id);
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            _orderServices.CreateOrder(order);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditOrder(Order order)
        {
            _orderServices.EditOrder(order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            _orderServices.DeleteOrder(id);
            return Ok();
        }
    }
}
