using System;
using System.Collections.Generic;
using DeliveryService.Models;

namespace DeliveryService.Database
{
    public class OrderDatabase
    {
        public List<Order> Orders { get; set; } = new List<Order>();

        public static void AddToOrderDataBase(OrderDatabase database, Order order)
        {
            database.Orders.Add(order);
        }
    }
}
