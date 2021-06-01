using System;
using System.Collections.Generic;
using Models.Models;

namespace Models.Database
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
