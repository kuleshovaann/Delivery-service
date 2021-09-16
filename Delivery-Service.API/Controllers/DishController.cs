using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeliveryService.Database;
using DeliveryService.Services;
using DeliveryService.Models;

namespace Delivery_Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Dish> Get()
        {
            var service = new DeliveryService.Services.CompanyServices(new OrderDatabase(new FileServices()), new Logger(), new FileServices());
            return service.GetMenu();
        }
    }
}

