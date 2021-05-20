using System;
using System.Collections.Generic;
using Models.Contracts;
using Models.Models;

namespace Models.Database
{
    public class OrderDatabase
    {
        public OrderDatabase()
        {
            Orders = new List<Order>();
        }

        public List<Order> Orders { get; set; }

        public static void AddTOOrderDataBase(OrderDatabase database, IOrder order)
        {
            database.Orders.Add((Order)order);
        }
    }
}
