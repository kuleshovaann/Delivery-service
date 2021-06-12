using DeliveryService.Contracts;
using System.Collections.Generic;
using DeliveryService.Models;

namespace DeliveryService.Database
{
    public class OrderDatabase : IOrderDatabase
    {
        public List<Order> Orders { get; set; } = new List<Order>();

        public List<Dish> DishesBase { get; set; } = new List<Dish>();
    }
}
