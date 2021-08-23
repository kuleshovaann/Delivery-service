using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Contracts;
using DeliveryService.Database;
using DeliveryService.Services;
using DeliveryService.Models;

namespace Delivery_Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // Task 1 ASP.Net

        //  GET/menu
        //  ADD/dish
        //  DELETE/dish
        //  POST/order/dish

        [HttpGet]
        [Route ("Anna")]
        public IEnumerable<Dish> Get()
        {
            var service = new DeliveryService.Services.CompanyServices(new OrderDatabase(new FileServices()), new Logger(), new FileServices());
            return service.GetMenu();

            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
