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

    //GET/menu
    //GET/dishes/{id}
    //POST/orders
    //GET//orders/{id}
    //DELETE/orders/{id}
    //GET/companies
    //GET/companies/{id}

    //GET/orders
    //GET/orders/{id}
    //PUT/orders/{id}
    //GET/customers
    //GET/customers/{id}
    //PUT/customers/{id}
    //POST/customers
    //DELETE/customers/{id}
}

