using System;
using System.Collections.Generic;
using DeliveryService.Contracts;
using DeliveryService.Models;

namespace DeliveryService.Database
{
    public class OrderDatabase
    {
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
