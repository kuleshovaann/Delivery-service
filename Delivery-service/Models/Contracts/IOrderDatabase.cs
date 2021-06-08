using DeliveryService.Models;
using System.Collections.Generic;

namespace DeliveryService.Contracts
{
    public interface IOrderDatabase
    {
        public List<Order> Orders { get; set; }

        public List<Dish> DishesBase { get; set; }
    }
}
