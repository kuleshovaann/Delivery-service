using System;
using System.Collections.Generic;
using Models.Contracts;
using Models.Models;

namespace Models.Database
{
    public class OrderBase
    {
        public OrderBase(IOrder order)
        {
            Orders = new List<Order>();
            Orders.Add((Order)order);
        }

        public List<Order> Orders { get; set; }

    }
}
