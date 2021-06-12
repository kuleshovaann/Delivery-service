using DeliveryService.Models;
using System.Collections.Generic;

namespace DeliveryService.Contracts
{
    public interface IOrderDatabase
    {
        List<Order> Orders { get; set; }

        List<Dish> Dishes { get; set; }
    }
}
