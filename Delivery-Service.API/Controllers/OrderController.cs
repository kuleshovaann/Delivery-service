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

        [HttpPost("{order}")]
        public void CreateOrder(Order order)
        {
            _orderServices.CreateOrder(order);
        }

        [HttpPut("{order}")]
        public void EditOrder(Order order)
        {
            _orderServices.EditOrder(order);
        }

        [HttpDelete("{id}")]
        public void DeleteOrder(int id)
        {
            _orderServices.DeleteOrder(id);
        }
    }
}
